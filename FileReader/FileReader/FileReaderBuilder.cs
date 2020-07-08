using FileReader.Constants;
using FileReader.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileReader
{
    public sealed class FileReaderBuilder
    {
        private string filePath;

        private FileReaderBuilder()
        {
        }

        public static FileReaderBuilder UseFilePath(string filePath)
        {
            var fileReaderBuilder = new FileReaderBuilder { filePath = filePath };

            return fileReaderBuilder;
        }

        public string ReadFile()
        {
            if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));
            if (!Path.HasExtension(filePath)) throw new ArgumentException("File extension is missing.", nameof(filePath));

            var fileReader = GetFileReader(filePath);
            string contents = fileReader.ReadFile();

            return contents;
        }

        private IFileReader GetFileReader(string filePath)
        {
            string extension = Path.GetExtension(filePath);
            extension = extension.ToLowerInvariant();

            switch (extension)
            {
                case SupportedExtensions.Text: return new TextFileReader(filePath);
                case SupportedExtensions.Xml: return new XmlFileReader(filePath);
                default: throw new ArgumentException("File extension not supported.", nameof(filePath));
            }
        }
    }
}