using System;
using System.Security.Cryptography;
using System.Text;

namespace MachineProject3_TMS
{
    internal static class SecurityHelpers
    {
        // Generates a salted SHA256 hash in the format: salt:hash (both Base64)
        public static string HashPassword(string password)
        {
            if (password == null) password = string.Empty;
            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            byte[] hash = ComputeHash(password, salt);

            return Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
        }

        public static bool VerifyPassword(string password, string stored)
        {
            if (string.IsNullOrEmpty(stored)) return false;
            var parts = stored.Split(new[] { ':' }, 2);
            if (parts.Length != 2) return false;

            try
            {
                var salt = Convert.FromBase64String(parts[0]);
                var expected = Convert.FromBase64String(parts[1]);
                var actual = ComputeHash(password ?? string.Empty, salt);
                return CryptographicOperations.FixedTimeEquals(expected, actual);
            }
            catch
            {
                return false;
            }
        }

        private static byte[] ComputeHash(string password, byte[] salt)
        {
            using (var sha = SHA256.Create())
            {
                byte[] pwd = Encoding.UTF8.GetBytes(password);
                byte[] combined = new byte[salt.Length + pwd.Length];
                Buffer.BlockCopy(salt, 0, combined, 0, salt.Length);
                Buffer.BlockCopy(pwd, 0, combined, salt.Length, pwd.Length);
                return sha.ComputeHash(combined);
            }
        }
    }
}
