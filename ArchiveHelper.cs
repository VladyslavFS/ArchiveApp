using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;

namespace ArchiveApp
{
    public static class ArchiveHelper
    {
        // Генерація ключа з пароля
        private static byte[] GetKey(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        /// <summary>
        /// Стискання файлу з можливістю шифрування.
        /// </summary>
        /// <param name="source">Шлях до початкового файлу.</param>
        /// <param name="destination">Шлях для збереження стислого файлу.</param>
        /// <param name="password">Пароль для шифрування (необов'язковий).</param>
        public static void Compress(string source, string destination, string password = null)
        {
            using (FileStream sourceStream = File.OpenRead(source))
            using (FileStream destStream = File.Create(destination))
            {
                if (!string.IsNullOrEmpty(password))
                {
                    byte[] key = GetKey(password);
                    using (Aes aes = Aes.Create())
                    {
                        aes.Key = key;
                        aes.GenerateIV();
                        destStream.Write(aes.IV, 0, aes.IV.Length); // Записуємо IV

                        using (CryptoStream cryptoStream = new CryptoStream(destStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        using (GZipStream compressionStream = new GZipStream(cryptoStream, CompressionMode.Compress))
                        {
                            sourceStream.CopyTo(compressionStream);
                        }
                    }
                }
                else
                {
                    using (GZipStream compressionStream = new GZipStream(destStream, CompressionMode.Compress))
                    {
                        sourceStream.CopyTo(compressionStream);
                    }
                }
            }
        }

        /// <summary>
        /// Розпаковка файлу з можливістю розшифрування.
        /// </summary>
        /// <param name="source">Шлях до стислого файлу.</param>
        /// <param name="destination">Шлях для збереження розпакованого файлу.</param>
        /// <param name="password">Пароль для розшифрування (необов'язковий).</param>
        public static void Decompress(string source, string destination, string password = null)
        {
            using (FileStream sourceStream = File.OpenRead(source))
            {
                if (!string.IsNullOrEmpty(password))
                {
                    byte[] key = GetKey(password);
                    byte[] iv = new byte[16];
                    sourceStream.Read(iv, 0, iv.Length); // Читаємо IV

                    using (Aes aes = Aes.Create())
                    {
                        aes.Key = key;
                        aes.IV = iv;

                        using (CryptoStream cryptoStream = new CryptoStream(sourceStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                        using (GZipStream decompressionStream = new GZipStream(cryptoStream, CompressionMode.Decompress))
                        using (FileStream destStream = File.Create(destination))
                        {
                            decompressionStream.CopyTo(destStream);
                        }
                    }
                }
                else
                {
                    using (GZipStream decompressionStream = new GZipStream(sourceStream, CompressionMode.Decompress))
                    using (FileStream destStream = File.Create(destination))
                    {
                        decompressionStream.CopyTo(destStream);
                    }
                }
            }
        }
    }
}
