using CryptoProjectApi.Entity;
using CryptoProjectApi.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoProjectApi.Context
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<PasswordLogWithSalt> PasswordLogsWithSalt { get; set; }
        public DbSet<PasswordLogWithoutSalt> PasswordLogsWithoutSalt { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var (passwordSalt, password) = GeneratePasswords(5);
            modelBuilder.Entity<PasswordLogWithSalt>().HasData(passwordSalt);
            modelBuilder.Entity<PasswordLogWithoutSalt>().HasData(password);
        }

        private (List<PasswordLogWithSalt>, List<PasswordLogWithoutSalt>) GeneratePasswords(int count)
        {
            var passwordSalt = new List<PasswordLogWithSalt>();
            var password = new List<PasswordLogWithoutSalt>();
            var pass = "test";
            Console.WriteLine(pass);
            for(int i = 1; i <= count; i++)
            {
                CriptoManager.CreateSecurityHash(pass, out byte[] hash, out byte[] salt);
                passwordSalt.Add(new PasswordLogWithSalt() { Id=i, Hash = hash, Salt = salt });
                CriptoManager.CreateSecurityEncrypt(pass, out byte[] hashEncrypt);
                password.Add(new PasswordLogWithoutSalt() { Id = i, Hash = hashEncrypt });
            }

            return (passwordSalt, password);
        }
    }
}
