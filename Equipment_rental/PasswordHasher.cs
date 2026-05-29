using System.Security.Cryptography;
using System.Text;

namespace Equipment_rental
{
    internal static class PasswordHasher
    {
        private const int SaltSize = 16;
        private const int HashSize = 32;
        private const int Iterations = 100_000;

        public static string HashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);
            byte[] hash = DeriveKey(password, salt);
            return $"{Convert.ToBase64String(salt)}:{Convert.ToBase64String(hash)}";
        }

        public static bool VerifyPassword(string password, string storedValue)
        {
            var parts = storedValue.Split(':', 2);
            if (parts.Length != 2)
                return false;

            try
            {
                byte[] salt = Convert.FromBase64String(parts[0]);
                byte[] expectedHash = Convert.FromBase64String(parts[1]);
                byte[] actualHash = DeriveKey(password, salt);
                return CryptographicOperations.FixedTimeEquals(expectedHash, actualHash);
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private static byte[] DeriveKey(string password, byte[] salt)
        {
            return Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                salt,
                Iterations,
                HashAlgorithmName.SHA256,
                HashSize);
        }
    }
}
