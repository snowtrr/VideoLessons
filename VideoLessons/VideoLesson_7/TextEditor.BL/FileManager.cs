﻿namespace TextEditor.BL
{
    using System.IO;
    using System.Text;

    public interface IFileManager<T>
    {
        string GetContent(T filePath);
        string GetContent(T filePath, Encoding encoding);
        void SaveContent(string content, T filePath);
        void SaveContent(string content, T filePath, Encoding encoding);
        int GetSymbolCount(string content);
        bool IsExist(T filePath);
    }

    public class FileManager : IFileManager<string>
    {
        private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251);

        public bool IsExist(string filePath)
        {
            var isExist = File.Exists(filePath);
            return isExist;
        }

        public string GetContent(string filePath)
        {
            var content = File.ReadAllText(filePath, _defaultEncoding);
            return content;
        }

        public string GetContent(string filePath, Encoding encoding)
        {
            var content = File.ReadAllText(filePath, encoding);
            return content;
        }

        public void SaveContent(string content, string filePath)
        {
            File.WriteAllText(filePath, content, _defaultEncoding);
        }

        public void SaveContent(string content, string filePath, Encoding encoding)
        {
            File.WriteAllText(filePath, content, encoding);
        }

        public int GetSymbolCount(string content)
        {
            var count = content.Length;
            return count;
        }
    }
}