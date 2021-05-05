using CryptoProjectApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoProjectApi.Interfaces
{
    public interface IActions
    {
        Task<List<TEntity>> Get<TEntity>() where TEntity : class, IPasswordEntityData;
        Task<TEntity> GetById<TEntity>(int id) where TEntity : class;
    }
}
