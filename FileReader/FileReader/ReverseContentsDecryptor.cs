using FileReader.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileReader
{
    public sealed class ReverseContentsDecryptor : IContentsDecryptor
    {
        public string Decrypt(string encryptedContents)
        {
            char[] array = encryptedContents.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
