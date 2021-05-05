using CryptoProjectApi.Context;
using CryptoProjectApi.Entity;
using CryptoProjectApi.Interfaces;
using CryptoProjectApi.Models;
using CryptoProjectApi.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoProjectApi.Services
{
    public class AccessService : IAccessService
    {
        private readonly DataContext _context;

        public AccessService(DataContext context)
        {
            _context = context;
        }
        
        public async Task<List<TEntity>> Get<TEntity>() where TEntity: class, IPasswordEntityData
        {
            var logs = await _context.Set<TEntity>().OrderByDescending(l => l.Id).ToListAsync();
            return logs;
        }

        public async Task<TEntity> GetById<TEntity>(int id) where TEntity: class
        {
            var log = await _context.Set<TEntity>().FindAsync(id);
            return log;
        }

        public async Task<TEntity> Create<TEntity>(IPassword passwordDto) where TEntity: class
        {
         
            dynamic log = null;
            if (typeof(TEntity) == typeof(PasswordLogWithSalt))
            {
                CriptoManager.CreateSecurityHash(passwordDto.Password, out byte[] hash, out byte[] salt);
                log = new PasswordLogWithSalt() { Hash = hash, Salt = salt };
            }
            else
            {
                CriptoManager.CreateSecurityEncrypt(passwordDto.Password, out byte[] hash);
                log = new PasswordLogWithoutSalt() { Hash = hash };
            }

            _context.Add(log);
            await _context.SaveChangesAsync();
            return log;
        }

        public async Task<(TEntity, int)> UpdatePassword<TEntity>(int id, PasswordSaltDto passwordDto) where TEntity : class, IPasswordEntityData
        {
            var query = _context.Set<TEntity>().AsQueryable();
            var log = await query.FirstOrDefaultAsync(l => l.Id == id);
            if (log == null)
                return (log, 404);
            var saltValue = log.GetType().GetProperty("Salt")?.GetValue(log);
            if(saltValue == null)
            {
                if (!CriptoManager.VerifySecurityEncrypt(passwordDto.Password, Convert.ToBase64String(log.Hash, 0, log.Hash.Length), out string data))
                    return (null, 400);
                Console.WriteLine(data);
            }
            else
            {
                if (!CriptoManager.VerifySecurityHash(passwordDto.Password, log.Hash, (byte[])saltValue))
                    return (null, 400);
            }
                


            if (typeof(TEntity) == typeof(PasswordLogWithSalt))
            {
                CriptoManager.CreateSecurityHash(passwordDto.NewPassword, out byte[] hash, out byte[] salt);
                log.GetType().GetProperty("Salt").SetValue(log, salt);
                log.Hash = hash;
            }
            else
            {
                CriptoManager.CreateSecurityEncrypt(passwordDto.NewPassword, out byte[] hash);
                log.Hash = hash;
                log.GetType().GetProperty("Decrypted").SetValue(log, CriptoManager.Decrypt(Convert.ToBase64String(log.Hash, 0, log.Hash.Length)));
            }
            

            _context.Update(log);
            await _context.SaveChangesAsync();
            return (log, 200);
        }
    }
}
