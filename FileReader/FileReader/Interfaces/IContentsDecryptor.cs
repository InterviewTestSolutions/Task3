using System;
using System.Collections.Generic;
using System.Text;

namespace FileReader.Interfaces
{
    public interface IContentsDecryptor
    {
        string Decrypt(string encryptedContents);
    }
}
