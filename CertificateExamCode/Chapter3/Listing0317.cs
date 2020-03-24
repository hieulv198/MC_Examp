using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateExamCode.Chapter3
{
    using System.IO;
    using System.Security.Cryptography;

    class Listing0317
    {
        public static void DoSample()
        {
            EncryptSomeText();
        }

        public static void EncryptSomeText()
        {
            string original = "My secret data!";

            using (SymmetricAlgorithm symmetricAlgorithm = new AesCng())
            {
                byte[] encryted = Encrypt(symmetricAlgorithm, original);

                var originByte = Encoding.ASCII.GetBytes(original);
                Console.WriteLine(string.Join(" ", originByte));
                Console.WriteLine(string.Join(" ", encryted));
                Console.Read();
            }
        }

        static byte[] Encrypt(SymmetricAlgorithm aesAlg, string plainText)
        {
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }
                    return msEncrypt.ToArray();
                }
            }
        }
    }
}
