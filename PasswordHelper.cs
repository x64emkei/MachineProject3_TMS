using System;
using System.Security.Cryptography;
using System.Text;

namespace MachineProject3_TMS
{
    public static class PasswordHelper
    {
        // Format: iterations.saltBase64.hashBase64
        public static string HashPassword(string password, int iterations = 10000)
        {
            if (password == null) throw new ArgumentNullException(nameof(password));
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[16];
                rng.GetBytes(salt);
                using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
                {
                    byte[] hash = pbkdf2.GetBytes(32);
                    return string.Format("{0}.{1}.{2}", iterations, Convert.ToBase64String(salt), Convert.ToBase64String(hash));
                }
            }
        }

        public static bool VerifyPassword(string stored, string password)
        {
            if (string.IsNullOrEmpty(stored) || password == null) return false;
            var parts = stored.Split('.');
            if (parts.Length != 3) return false;
            if (!int.TryParse(parts[0], out int iterations)) return false;
            byte[] salt = Convert.FromBase64String(parts[1]);
            byte[] hash = Convert.FromBase64String(parts[2]);
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
            {
                byte[] testHash = pbkdf2.GetBytes(hash.Length);
                return AreEqualSlow(hash, testHash);
            }
        }

        private static bool AreEqualSlow(byte[] a, byte[] b)
        {
            if (a.Length != b.Length) return false;
            int diff = 0;
            for (int i = 0; i < a.Length; i++) diff |= a[i] ^ b[i];
            return diff == 0;
        }
    }
}
