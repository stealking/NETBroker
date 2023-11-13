using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace Core.Extensions
{
    public static class StringExtensions
    {
        public static string HashPassword(this string password)
        {
            // Generate a random salt (unique for each user)
            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            // Convert the password string to a byte array
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

            // Combine the salt and password bytes
            byte[] saltedPasswordBytes = new byte[salt.Length + passwordBytes.Length];
            Buffer.BlockCopy(salt, 0, saltedPasswordBytes, 0, salt.Length);
            Buffer.BlockCopy(passwordBytes, 0, saltedPasswordBytes, salt.Length, passwordBytes.Length);

            // Hash the salted password using a secure hash algorithm like PBKDF2
            using (var hasher = new Rfc2898DeriveBytes(saltedPasswordBytes, salt, 10000, HashAlgorithmName.SHA256))
            {
                byte[] hash = hasher.GetBytes(32); // 256 bits
                byte[] hashPlusSalt = new byte[salt.Length + hash.Length];
                Buffer.BlockCopy(salt, 0, hashPlusSalt, 0, salt.Length);
                Buffer.BlockCopy(hash, 0, hashPlusSalt, salt.Length, hash.Length);

                return Convert.ToBase64String(hashPlusSalt);
            }
        }

        public static bool VerifyHashedPassword(this string storedHashedPassword, string enteredPassword)
        {
            // Decode the stored hashed password
            byte[] hashPlusSalt = Convert.FromBase64String(storedHashedPassword);

            // Extract the salt
            byte[] salt = new byte[16];
            Buffer.BlockCopy(hashPlusSalt, 0, salt, 0, salt.Length);

            // Convert the entered password to a byte array
            byte[] enteredPasswordBytes = System.Text.Encoding.UTF8.GetBytes(enteredPassword);

            // Combine the salt and entered password bytes
            byte[] saltedEnteredPasswordBytes = new byte[salt.Length + enteredPasswordBytes.Length];
            Buffer.BlockCopy(salt, 0, saltedEnteredPasswordBytes, 0, salt.Length);
            Buffer.BlockCopy(enteredPasswordBytes, 0, saltedEnteredPasswordBytes, salt.Length, enteredPasswordBytes.Length);

            // Hash the salted entered password
            using (var hasher = new Rfc2898DeriveBytes(saltedEnteredPasswordBytes, salt, 10000, HashAlgorithmName.SHA256))
            {
                byte[] hashToCheck = hasher.GetBytes(32); // 256 bits

                // Compare the computed hash with the stored hash
                for (int i = 0; i < hashToCheck.Length; i++)
                {
                    if (hashToCheck[i] != hashPlusSalt[salt.Length + i])
                    {
                        return false; // Passwords don't match
                    }
                }
                return true; // Passwords match
            }
        }

        public static int ConvertToIntOrDefault(this string name, int defaultValue)
        {
            int result = defaultValue;

            var resultConvert = int.TryParse(name, NumberStyles.Number, new CultureInfo("en-US"), out result);

            return resultConvert ? result : defaultValue;
        }
    }
}
