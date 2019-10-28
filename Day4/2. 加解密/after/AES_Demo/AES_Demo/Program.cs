using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AES_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            AES_Encryptor aes = new AES_Encryptor();

            string text = "mypassword";

            // 指定演算法
            AesCryptoServiceProvider key = new AesCryptoServiceProvider();

            // 加密
            byte[] encryptedText = aes.Encrypt(text, key);
            Console.WriteLine(Convert.ToBase64String(encryptedText));

            // 解密
            string decryptedText = aes.Decrypt(encryptedText, key);
            Console.WriteLine(decryptedText);
        }
    }
}
