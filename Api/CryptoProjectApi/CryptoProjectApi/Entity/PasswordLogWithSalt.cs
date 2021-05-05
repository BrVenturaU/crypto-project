using CryptoProjectApi.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoProjectApi.Entity
{
    public class PasswordLogWithSalt: IPasswordEntityData
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public byte[] Hash { get; set; }
        [Required]
        public byte[] Salt { get; set; }
    }
}
