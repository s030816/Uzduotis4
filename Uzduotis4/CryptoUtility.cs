using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Uzduotis4
{
    class CryptoUtility
    {
        private const int SALT_SIZE = 24; // size in bytes
        private const int HASH_SIZE = 24; // size in bytes
        private const int ITERATIONS = 10000;
        public string Pbkdf2Function(string input, byte[] salt)
        {
            // Generate a salt
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            if (salt == null)
            {
                salt = new byte[SALT_SIZE];
                provider.GetBytes(salt);
            }
            // Generate the hash
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(input, salt, ITERATIONS);
            return Convert.ToBase64String(salt)+"?"+Convert.ToBase64String(pbkdf2.GetBytes(HASH_SIZE));
        }

        public bool PwAuthorize(string pw, string hashedpw)
        {
            return Pbkdf2Function(pw, Convert.FromBase64String(hashedpw.Split('?')[0])) == hashedpw;
        }
        
        public string EncodeStr(string input, string key)
        {
            string encrypted = null;
            using (Aes aesAlg = Aes.Create())
            {
                int ksize = aesAlg.KeySize / 8;
                byte[] tmp_key = new byte[ksize];
                var tmp = Encoding.ASCII.GetBytes(key, 0, key.Length);
                for (var i = 0; i < ksize && i < tmp.Length; ++i)
                {
                    tmp_key[i] = tmp[i];
                }
                encrypted = Convert.ToBase64String(aesAlg.IV) + '\n';
                // TODO Implement string stream
                
                encrypted += Convert.ToBase64String(EncryptStringToBytes_Aes(input, tmp_key, aesAlg.IV)) + '\n';
            }
               

                // Decrypt the bytes to a string.
               //string roundtrip = DecryptStringFromBytes_Aes(encrypted, myAes.Key, myAes.IV);

                //Display the original data and the decrypted data.
                //Console.WriteLine("Original:   {0}", encrypted);
                //Console.WriteLine("Round Trip: {0}", roundtrip);
            
            return encrypted;
        }
        private byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return encrypted;
        }

        private string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
    }
}
