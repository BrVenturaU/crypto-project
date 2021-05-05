using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoProjectApi.Interfaces
{
    public interface IPassword
    {
        public string Password { get; set; }
        public string NewPassword { get; set; }
    }
}
