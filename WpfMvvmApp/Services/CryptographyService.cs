using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfMvvmApp.Services
{
    interface ICryptographyService
    {
        byte[] EncryptByAES128(string plainText);
        string DecryptByAES128(byte[] encryptBytes);
    }

    public class CryptographyService : ICryptographyService
    {

        //인증키 정의
        private readonly byte[] KEY = Encoding.UTF8.GetBytes("wpfcryptojsonapp");

        private readonly byte[] IV = Encoding.UTF8.GetBytes("0F12DE34BC569A78");

        public byte[] EncryptByAES128(string plainText)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

            Aes aes = Aes.Create();

            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            aes.KeySize = 128;

            MemoryStream memoryStream = new MemoryStream();

            ICryptoTransform encryptor = aes.CreateEncryptor(KEY, IV);

            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainBytes, 0, plainBytes.Length);
            cryptoStream.FlushFinalBlock();

            byte[] encryptBytes = memoryStream.ToArray();

            cryptoStream.Close();
            memoryStream.Close();

            return encryptBytes;
        }

        public string DecryptByAES128(byte[] encryptBytes)
        {
            Aes aes = Aes.Create();

            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;
            aes.KeySize = 128;

            MemoryStream memoryStream = new MemoryStream(encryptBytes);
            ICryptoTransform decryptor = aes.CreateDecryptor(KEY, IV);

            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);

            byte[] plainBytes = new byte[encryptBytes.Length];

            int plainCount = cryptoStream.Read(plainBytes, 0, plainBytes.Length);

            string plainString = Encoding.UTF8.GetString(plainBytes, 0, plainCount);

            cryptoStream.Close();
            memoryStream.Close();

            return plainString;
        }

    }
}
