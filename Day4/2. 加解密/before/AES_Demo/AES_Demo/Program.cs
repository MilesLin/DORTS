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
            string text = "mypassword";

            // 指定 AES 演算法
            AesCryptoServiceProvider key = new AesCryptoServiceProvider();


            #region 加密程式碼

            byte[] encryptedData;

            // 加密程式碼
            // 建立MemoryStream，要傳入CryptoStream使用
            using (MemoryStream ms = new MemoryStream())
            {
                // 建立 CryptoStream ，建構式需傳入 1.Stream 2.指定演算法的加密方法 3.指定密碼編譯資料流的模式
                using (CryptoStream cs = new CryptoStream(ms, key.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    // 將字串寫入stream，交給CryptoStream 加密
                    StreamWriter sw = new StreamWriter(cs);
                    sw.WriteLine(text);
                    sw.Close();
                }
                // 輸出加密後資料
                encryptedData = ms.ToArray();
            }

            Console.WriteLine($"加密後的字串: {Convert.ToBase64String(encryptedData)}");

            #endregion

            #region 解密

            string decryptResult;
            // 建立MemoryStream，要傳入CryptoStream使用
            using (MemoryStream ms = new MemoryStream(encryptedData))
            {
                // 建立 CryptoStream ，建構式需傳入 1.Stream 2.指定演算法的解密方法 3.指定密碼編譯資料流的模式
                using (CryptoStream crypstream = new CryptoStream(ms, key.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    // 使用StreamReader讀取CryptoStream資料
                    using (StreamReader sr = new StreamReader(crypstream))
                    {
                        // 解密後輸出
                        decryptResult = sr.ReadLine();
                    }
                }
            }

            Console.WriteLine($"解密後的字串: {decryptResult}");

            #endregion
        }
    }
}
