using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace PaternExamNew
{
    public interface IStrategy
    {
        MyFile Open(MyFile file TextRange doc);

        bool Save(MyFile file);

        bool SaveNewName(MyFile file);

        bool Print(MyFile file);
    }
}