﻿using FileReader.Constants;
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
        private IContentsDecryptor decryptor = null;

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

        public string ReadFile()
        {
            if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));
            if (!Path.HasExtension(filePath)) throw new ArgumentException("File extension is missing.", nameof(filePath));

            string extension = Path.GetExtension(filePath);
            extension = extension.ToLowerInvariant();

            var fileReader = GetFileReader(filePath, extension);
            string contents = fileReader.ReadFile();

            if (decryptor != null)
            {
                if (extension == SupportedExtensions.Text)
                {
                    contents = decryptor.Decrypt(contents);
                }
                else
                {
                    throw new ArgumentException("Decrypting non-Text file is not poosible.");
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
                default: throw new ArgumentException("File extension not supported.", nameof(filePath));
            }
        }
    }
}
