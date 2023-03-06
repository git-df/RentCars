using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Auth
{
    public static class AuthPasswordHashHandler
    {
        public static string HashPassword(string password, string salt)
        {
            SHA256 sHA256 = SHA256.Create();
            var passwordBytes = Encoding.Default.GetBytes($"{password}{salt}");
            var passwordHash = sHA256.ComputeHash(passwordBytes);
            return Convert.ToHexString(passwordHash);
        }

        public static string SaltGenerator()
        {
            var rng = RandomNumberGenerator.Create();
            byte[] salt = new byte[32];
            rng.GetNonZeroBytes(salt);
            return Convert.ToHexString(salt);
        }
    }
}
