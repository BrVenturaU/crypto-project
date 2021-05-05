using CryptoProjectApi.Entity;
using CryptoProjectApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoProjectApi.Interfaces
{
    public interface IAccessService : IActions
    {
        Task<TEntity> Create<TEntity>(IPassword passwordDto) where TEntity : class;
        Task<(TEntity, int)> UpdatePassword<TEntity>(int id, PasswordSaltDto passwordDto) where TEntity : class, IPasswordEntityData;

    }
}
