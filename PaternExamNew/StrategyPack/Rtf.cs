using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace PaternExamNew
{
    class RTF : IStrategy
    {
        public MyFile Open(MyFile file, TextRange doc)
        {
            using (FileStream fs = File.Create(file.FilePath))
            {
                    doc.Save(fs, DataFormats.Rtf);
            }
            FileInfo nj = new FileInfo(file.FilePath);
            MyFile newFile = new MyFile();
            newFile.FileName = nj.Name;
            return newFile;
        }

        public bool Print(MyFile file)
        {
            throw new NotImplementedException();
        }

        public bool Save(MyFile file)
        {
            throw new NotImplementedException();
        }

        public bool SaveNewName(MyFile file)
        {
            throw new NotImplementedException();
        }
    }
}
