using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoProjectApi.Utils
{
    public class CriptoManager
    {
        // Hash
        private const string _myPrivateKey = "*1234567890!@#$%^&*()14344*";
        public static void CreateSecurityHash(string valueToSecure, out byte[] hash, out byte[] salt)
        {
            if (valueToSecure == null) throw new ArgumentNullException(nameof(valueToSecure));
            if (string.IsNullOrWhiteSpace(valueToSecure)) throw new ArgumentException("El valor no puede estar vacio o solo traer un espacio en blanco.", nameof(valueToSecure));

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                salt = hmac.Key;
                hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(valueToSecure));
            }
        }

        public static void CreateSecurityHash(string valueToSecure, out byte[] hash)
        {
            if (valueToSecure == null) throw new ArgumentNullException(nameof(valueToSecure));
            if (string.IsNullOrWhiteSpace(valueToSecure)) throw new ArgumentException("El valor no puede estar vacio o solo traer un espacio en blanco.", nameof(valueToSecure));

            using (var hmac = new System.Security.Cryptography.HMACSHA512(Encoding.UTF8.GetBytes(_myPrivateKey)))
            {
                hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(valueToSecure));
            }
        }
      
        public static bool VerifySecurityHash(string valueToVerify, byte[] hash, byte[] salt)
        {
            if (valueToVerify == null) throw new ArgumentNullException(nameof(valueToVerify));
            if (string.IsNullOrWhiteSpace(valueToVerify)) throw new ArgumentException("El valor no puede estar vacio o solo traer un espacio en blanco.", nameof(valueToVerify));
            if (hash.Length != 64) throw new ArgumentException("Cantidad de caracteres invalidos para el hash de la contraseña (64 bytes esperados).", nameof(hash));
            if (salt.Length != 128) throw new ArgumentException("Cantidad de caracteres invalidos para el password salt (128 bytes esperados).", nameof(salt));

            using (var hmac = new System.Security.Cryptography.HMACSHA512(salt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(valueToVerify));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != hash[i]) return false;
                }
            }

            return true;
        }

        public static bool VerifySecurityHash(string valueToVerify, byte[] hash)
        {
            if (valueToVerify == null) throw new ArgumentNullException(nameof(valueToVerify));
            if (string.IsNullOrWhiteSpace(valueToVerify)) throw new ArgumentException("El valor no puede estar vacio o solo traer un espacio en blanco.", nameof(valueToVerify));
            if (hash.Length != 64) throw new ArgumentException("Cantidad de caracteres invalidos para el hash de la contraseña (64 bytes esperados).", nameof(hash));

            using (var hmac = new System.Security.Cryptography.HMACSHA512(Encoding.UTF8.GetBytes(_myPrivateKey)))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(valueToVerify));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != hash[i]) return false;
                }
            }

            return true;
        }


        // Encriptado 
        public static void CreateSecurityEncrypt(string valueToSecure, out byte[] hash)
        {
            if (valueToSecure == null) throw new ArgumentNullException(nameof(valueToSecure));
            if (string.IsNullOrWhiteSpace(valueToSecure)) throw new ArgumentException("El valor no puede estar vacio o solo traer un espacio en blanco.", nameof(valueToSecure));

            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(valueToSecure);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(_myPrivateKey));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    hash = transform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                }
            }
        }

        public static bool VerifySecurityEncrypt(string password, string valueToVerify, out string resultData)
        {
            if (valueToVerify == null) throw new ArgumentNullException(nameof(valueToVerify));
            if (string.IsNullOrWhiteSpace(valueToVerify)) throw new ArgumentException("El valor no puede estar vacio o solo traer un espacio en blanco.", nameof(valueToVerify));

            byte[] resultArray = Convert.FromBase64String(valueToVerify); 
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(_myPrivateKey));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(resultArray, 0, resultArray.Length);
                    resultData = UTF8Encoding.UTF8.GetString(results);
                    return password == resultData;
                }
            }
        }

        public static string Decrypt(string valueToVerify)
        {
            if (valueToVerify == null) throw new ArgumentNullException(nameof(valueToVerify));
            if (string.IsNullOrWhiteSpace(valueToVerify)) throw new ArgumentException("El valor no puede estar vacio o solo traer un espacio en blanco.", nameof(valueToVerify));

            byte[] resultArray = Convert.FromBase64String(valueToVerify);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(_myPrivateKey));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(resultArray, 0, resultArray.Length);
                    var resultData = UTF8Encoding.UTF8.GetString(results);
                    return resultData;
                }
            }
        }
    }
}
