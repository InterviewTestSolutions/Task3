using FileReader.Constants;
using FileReader.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileReader
{
    public sealed class FileReaderBuilder
    {
        private readonly string[] decryptionAvailableForFileExtensions = { SupportedExtensions.Text, SupportedExtensions.Xml, SupportedExtensions.Json };

        private string filePath;
        private IContentsDecryptor decryptor = null;
        private IRoleChecker roleChecker = null;

        private FileReaderBuilder()
        {
        }

        public static FileReaderBuilder UseFilePath(string filePath)
        {
            var fileReaderBuilder = new FileReaderBuilder { filePath = filePath };

            return fileReaderBuilder;
        }

        public FileReaderBuilder UseDecryptor(IContentsDecryptor decryptor)
        {
            this.decryptor = decryptor;
            return this;
        }

        public FileReaderBuilder UseRoleChecker(IRoleChecker roleChecker)
        {
            this.roleChecker = roleChecker;
            return this;
        }

        public string ReadFile()
        {
            if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));
            if (!Path.HasExtension(filePath)) throw new ArgumentException("File extension is missing.", nameof(filePath));

            string extension = Path.GetExtension(filePath);
            extension = extension.ToLowerInvariant();

            if (roleChecker != null)
            {
                if (extension == SupportedExtensions.Text || extension == SupportedExtensions.Xml)
                {
                    roleChecker.VerifyPermissions(filePath);
                }
                else
                {
                    throw new ArgumentException("Checking permissions is not poosible for the selected file extension.");
                }
            }

            var fileReader = GetFileReader(filePath, extension);
            string contents = fileReader.ReadFile();

            if (decryptor != null)
            {
                if (decryptionAvailableForFileExtensions.Contains(extension))
                {
                    contents = decryptor.Decrypt(contents);
                }
                else
                {
                    throw new ArgumentException("Decrypting is not poosible for the selected file extension.");
                }
            }

            return contents;
        }

        private IFileReader GetFileReader(string filePath, string extension)
        {
            switch (extension)
            {
                case SupportedExtensions.Text: return new TextFileReader(filePath);
                case SupportedExtensions.Xml: return new XmlFileReader(filePath);
                case SupportedExtensions.Json: return new JsonFileReader(filePath);
                default: throw new ArgumentException("File extension not supported.", nameof(filePath));
            }
        }
    }
}
