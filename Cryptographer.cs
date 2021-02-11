using System;

namespace SimpleEncrDecr
{
    public static class Cryptographer
    {
        //this key is used for encrypting and also decrypting
        private const string key = "+1a_2b-3c&";

        public static string EncryptText(string text)
        {
            string result = string.Empty;
            if (!string.IsNullOrEmpty(text))
            {
                char[] encryptedText = new char[text.Length];
                for (int i = 0, j = 0; i < text.Length; i++)
                {
                    encryptedText[i] = Convert.ToChar(text[i] ^ key[j]);
                    j = j < key.Length ? j++ : 0;
                }
                Array.Reverse(encryptedText);
                result = new string(encryptedText);
            }

            return result;
        }
        public static string DecryptText(string text)
        {
            string result = string.Empty;
            if (!string.IsNullOrEmpty(text))
            {
                char[] decryptedText = new char[text.Length];
                for (int i = 0, j = 0; i < text.Length; i++)
                {
                    decryptedText[i] = Convert.ToChar(text[i] ^ key[j]);
                    j = j < key.Length ? j++ : 0;
                }
                Array.Reverse(decryptedText);
                result = new string(decryptedText);
            }

            return result;
        }
    }
}
