using System;
using System.Security.Cryptography;

public class PasswordHash
{
    // Generate a hash for a plain text password using PBKDF2
    public static string HashPassword(string password)
    {
        // Generate a 16-byte salt using a secure RNG
        byte[] salt = new byte[16];
        using (var rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(salt); // Fill salt array with cryptographically strong random bytes
        }

        // Hash the password using PBKDF2 with 100,000 iterations and SHA256
        using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA256))
        {
            byte[] hash = pbkdf2.GetBytes(32); 

          
            byte[] hashBytes = new byte[48];
            Array.Copy(salt, 0, hashBytes, 0, 16); 
            Array.Copy(hash, 0, hashBytes, 16, 32); 

            // Return the combined salt+hash as a Base64 string for storage
            return Convert.ToBase64String(hashBytes);
        }
    }

    // Verify if the entered password matches the stored hash
    public static bool VerifyPassword(string storedHash, string enteredPassword)
    {
        // Reject if entered password is a hash to prevent incorrect user input
        if (IsHash(enteredPassword))
        {
            return false;
        }

        // Decode the stored Base64-encoded hash into byte array
        byte[] hashBytes;
        try
        {
            hashBytes = Convert.FromBase64String(storedHash);
        }
        catch (FormatException)
        {
            // If the stored hash is not a valid Base64 string, return false
            return false;
        }

        // Ensure the decoded byte array has the correct length (48 bytes: 16 bytes salt + 32 bytes hash)
        if (hashBytes.Length != 48)
        {
            return false;
        }

        // Extract the salt from the first 16 bytes of the stored hash
        byte[] salt = new byte[16];
        Array.Copy(hashBytes, 0, salt, 0, 16);

        // Hash the entered password with the extracted salt using the same PBKDF2 parameters
        using (var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, 100000, HashAlgorithmName.SHA256))
        {
            byte[] enteredHash = pbkdf2.GetBytes(32); 

            // Compare the hashes in constant time to prevent timing attacks
            return ConstantTimeComparison(hashBytes, enteredHash);
        }
    }

    // Check if the input is a Base64-encoded hash (used to prevent user inputting a hash instead of a password)
    public static bool IsHash(string input)
    {
        // Check if the input has the expected length of a Base64-encoded hash (64 characters for 48 bytes)
        if (input.Length == 64)
        {
            try
            {
                byte[] decodedBytes = Convert.FromBase64String(input);
                return decodedBytes.Length == 48; // Ensure the decoded byte array is 48 bytes long
            }
            catch (FormatException)
            {
              
                return false;
            }
        }
        return false;
    }

    // Perform a constant-time comparison of the stored and entered hashes to prevent timing attacks
    private static bool ConstantTimeComparison(byte[] storedHashBytes, byte[] enteredHash)
    {
        // Start with the assumption that the hashes are the same
        int diff = 0;

        // Compare only the hash portion (not the salt)
        for (int i = 0; i < 32; i++) // 32 bytes for SHA256 hash
        {
            diff |= storedHashBytes[i + 16] ^ enteredHash[i]; // XOR comparison for constant-time execution
        }

        // Return true only if the hashes match (diff remains 0)
        return diff == 0;
    }
}
