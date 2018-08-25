using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace PaternExamNew
{
    public class MyFile
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public byte[] Data { get; set; }
        public IStrategy Strategy { get; set; }
        public MyFile()
        {

        }
        public MyFile(string filePath, string fileName, string extension, byte[] data)
        {
            FilePath = filePath;
            FileName = fileName;
            Extension = extension;
            Data = data;
        }

        //public static void FileWrite(File file) { }
        //public static File FileRead(string filePath) { return null; }

        public void Open(TextRange doc) { Strategy.Open(this); }

        public void Save() { Strategy.Save(this); }

        public void SaveNewName(string newPath) { Strategy.SaveNewName(this); }

        public void Print() { Strategy.Print(this); }

        public void SetStrategy(IStrategy strategy)
        {
            Strategy = strategy;
        }
    }
}
