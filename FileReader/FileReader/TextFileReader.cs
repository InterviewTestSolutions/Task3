using FileReader.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileReader
{
    public sealed class TextFileReader : IFileReader
    {
        private readonly string filePath;

        public TextFileReader(string filePath)
        {
            this.filePath = filePath;
        }

        public string ReadFile()
        {
            return File.ReadAllText(filePath);
        }
    }
}
