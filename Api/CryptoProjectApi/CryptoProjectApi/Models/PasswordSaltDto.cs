using CryptoProjectApi.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoProjectApi.Models
{
    public class PasswordSaltDto : IPassword
    {
        [Required(ErrorMessage = "La contraseña anterior es requerida.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "La nueva contraseña es requerida.")]
        [Compare("ConfirmPassword", ErrorMessage = "Las contraseñas deben ser iguales.")]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "La contraseña de confirmación es requerida.")]
        [Compare("NewPassword", ErrorMessage = "Las contraseñas deben ser iguales.")]
        public string ConfirmPassword { get; set; }
    }
}
