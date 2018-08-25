using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PaternExamNew
{
    public class LanguagePack
    {
        public Dictionary<string, string> WordLibrary { get; set; }

        public LanguagePack()
        {
            WordLibrary = new Dictionary<string, string>();
        }

        public virtual void Apllying(MainWindow window)
        {
            (window.FindName("createButton") as Button).Content = WordLibrary["Create"];

            (window.FindName("openButton") as Button).Content = WordLibrary["Open"];

            (window.FindName("saveButton") as Button).Content = WordLibrary["Save"];

            (window.FindName("saveNewNameButton") as Button).Content = WordLibrary["SaveNewName"];

            (window.FindName("printButton") as Button).Content = WordLibrary["Print"];

            (window.FindName("closeButton") as Button).Content = WordLibrary["Close"];
        }
    }
}
