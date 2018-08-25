using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace PaternExamNew
{
    public class FileManager
    {
        public List<MyFile> Files { get; set; }
        public int CurrentFileId { get; set; }

        public FileManager()
        {
            Files = new List<MyFile>();
        }

        public void CreateFile(MyFile file)
        {
            Files.Add(file);
            CurrentFileId = Files.Count - 1;
        }
        public MyFile OpenFile(string filePath, string fileExtension, TextRange doc)
        {
            MyFile file = new MyFile
            {
                Extension = fileExtension
            };
            Type TestType = Type.GetType("PaternExamNew." + fileExtension.ToUpper(), false, true);

            //если класс не найден
            if (TestType != null)
            {
                //получаем конструктор
                System.Reflection.ConstructorInfo ci = TestType.GetConstructor(new Type[] { });

                //вызываем конструтор
                object Obj = ci.Invoke(new object[] { });
                file.SetStrategy(Obj as IStrategy);
            }
            else
            {
                MessageBox.Show("Расширение не поддерживается");
            }
            file.Open(doc);
            Files.Add(file);
            CurrentFileId = Files.Count - 1;
            return Files[CurrentFileId];
        }
        public void SaveFile()
        {
            Files[CurrentFileId].Save();
        }
        public void SaveNewNameFile(string filePath)
        {
            Files[CurrentFileId].SaveNewName(filePath);
        }
        public void PrintFile()
        {
            Files[CurrentFileId].Print();
        }
        public void CloseFile()
        {
            Files.RemoveAt(CurrentFileId);
        }
    }
}
