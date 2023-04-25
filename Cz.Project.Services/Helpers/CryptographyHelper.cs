using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Cz.Project.Services.Helpers
{
    public static class Cryptography
    {
        public static string Encrypt(string input)
        {
            var IV = ASCIIEncoding.ASCII.GetBytes("qualityi");
            var EncryptionKey = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5");
            var buffer = Encoding.UTF8.GetBytes(input);
            var des = new TripleDESCryptoServiceProvider();
            des.Key = EncryptionKey;
            des.IV = IV;
            return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length));
        }

        public static string Decrypt(string input)
        {
            var IV = ASCIIEncoding.ASCII.GetBytes("qualityi");
            var EncryptionKey = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5");
            var buffer = Convert.FromBase64String(input);
            var des = new TripleDESCryptoServiceProvider();
            des.Key = EncryptionKey;
            des.IV = IV;
            return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length));
        }

        public static string Hash(string input)
        {
            MD5 mMD5Hash = MD5.Create();
            byte[] mBytes = mMD5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder mStringBuilder = new StringBuilder();
            for (int i = 0; i <= mBytes.Length - 1; i++)
            {
                mStringBuilder.Append(mBytes[i].ToString("X2"));
            }
            return mStringBuilder.ToString();
        }
    }
}
