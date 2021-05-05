using CryptoProjectApi.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoProjectApi.Entity
{
    public class PasswordLogWithoutSalt: IPasswordEntityData
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public byte[] Hash { get; set; }
        [NotMapped]
        public string Decrypted { get; set; }
    }
}
