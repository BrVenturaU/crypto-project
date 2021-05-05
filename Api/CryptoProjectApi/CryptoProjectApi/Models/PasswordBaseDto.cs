using CryptoProjectApi.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CryptoProjectApi.Models
{
    public class PasswordBaseDto : IPassword
    {
        [Required(ErrorMessage = "La contraseña es requerida.")]
        public string Password { get; set; }
        [JsonIgnore]
        public string NewPassword { get; set; }
    }
}
