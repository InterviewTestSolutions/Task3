using FileReader.Interfaces;
using System.IO;
using System.Xml;

namespace FileReader
{
    public sealed class XmlFileReader : IFileReader
    {
        private readonly string filePath;

        public XmlFileReader(string filePath)
        {
            this.filePath = filePath;
        }

        public string ReadFile()
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(filePath);

            var node = xmlDocument.DocumentElement.SelectSingleNode("/contents");
            return node.InnerText;
        }
    }
}
