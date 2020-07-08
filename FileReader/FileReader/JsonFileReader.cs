using FileReader.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileReader
{
    public sealed class JsonFileReader : IFileReader
    {
        private readonly string filePath;

        public JsonFileReader(string filePath)
        {
            this.filePath = filePath;
        }

        public string ReadFile()
        {
            var text = File.ReadAllText(filePath);

            var json = JObject.Parse(text);

            string result = (string)json["contents"];
            return result;
        }
    }
}
