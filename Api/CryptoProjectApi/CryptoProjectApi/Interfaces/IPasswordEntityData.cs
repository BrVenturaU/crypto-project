using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoProjectApi.Interfaces
{
    public interface IPasswordEntityData
    {
        public int Id { get; set; }
        public byte[] Hash { get; set; }
    }
}
