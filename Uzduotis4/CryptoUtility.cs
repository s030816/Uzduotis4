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
        public void EncodeStr(string input)
        {
            string original = "Here is some data to encrypt!";

            // Create a new instance of the Aes
            // class.  This generates a new key and initialization
            // vector (IV).
            using (Aes myAes = Aes.Create())
            {

                // Encrypt the string to an array of bytes.
                //byte[] encrypted = EncryptStringToBytes_Aes(original, myAes.Key, myAes.IV);

                // Decrypt the bytes to a string.
                //string roundtrip = DecryptStringFromBytes_Aes(encrypted, myAes.Key, myAes.IV);

                //Display the original data and the decrypted data.
                Console.WriteLine("Original:   {0}", original);
                //Console.WriteLine("Round Trip: {0}", roundtrip);
            }

        }
    }
}
