using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace UIProject.Securities
{
    internal class SaltPassword
    {
        public static string ComputeHash(string plainText, string hashAlgorithm, byte[] saltBytes)
        {
            if (saltBytes == null)
            {
                var minSaltBytes = 4;
                var maxSaltBytes = 8;
                var random = new Random();
                var saltSize = random.Next(minSaltBytes, maxSaltBytes);
                saltBytes = new byte[saltSize];
                var rng = new RNGCryptoServiceProvider();
                rng.GetNonZeroBytes(saltBytes);
            }
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            var plainTextWithSaltBytes = new byte[plainTextBytes.Length + saltBytes.Length];
            for (var i = 0; i < plainTextBytes.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainTextBytes[i];
            }
            for (var i = 0; i < saltBytes.Length; i++)
            {
                plainTextWithSaltBytes[plainTextBytes.Length + i] = saltBytes[i];
            }
            HashAlgorithm hash;

            if (hashAlgorithm == null)
            {
                hashAlgorithm = string.Empty;
            }
            switch (hashAlgorithm.ToUpper())
            {
                case "SHA384":
                    hash = new SHA384Managed();
                    break;

                case "SHA512":
                    hash = new SHA512Managed();
                    break;

                default:
                    hash = new MD5CryptoServiceProvider();
                    break;
            }
            var hashBytes = hash.ComputeHash(plainTextWithSaltBytes);
            var hashWithSaltBytes = new byte[hashBytes.Length + saltBytes.Length];

            for (var i = 0; i < hashBytes.Length; i++)
            {
                hashWithSaltBytes[i] = hashBytes[i];
            }


            for (var i = 0; i < saltBytes.Length; i++)
            {
                hashWithSaltBytes[hashBytes.Length + i] = saltBytes[i];
            }


            var hashValue = Convert.ToBase64String(hashWithSaltBytes);

            return hashValue;
        }
        public static bool VerifyHash(string plainText, string hashAlgorithm, string hashValue)
        {
            var hashWithSaltBytes = Convert.FromBase64String(hashValue);
            int hashSizeInBits, hashSizeInBytes;
            if (hashAlgorithm == null)
            {
                hashAlgorithm = string.Empty;
            }

            switch (hashAlgorithm.ToUpper())
            {
                case "SHA384":
                    hashSizeInBits = 384;
                    break;

                case "SHA512":
                    hashSizeInBits = 512;
                    break;

                default:
                    hashSizeInBits = 128;
                    break;
            }
            hashSizeInBytes = hashSizeInBits / 8;
            if (hashWithSaltBytes.Length < hashSizeInBytes)
            {
                return false;
            }
            var saltBytes = new byte[hashWithSaltBytes.Length - hashSizeInBytes];

            for (var i = 0; i < saltBytes.Length; i++)
            {
                saltBytes[i] = hashWithSaltBytes[hashSizeInBytes + i];
            }

            var expectedHashString = ComputeHash(plainText, hashAlgorithm, saltBytes);

            return (hashValue == expectedHashString);
        }
    }
}
