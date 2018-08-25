using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternExamNew
{
    public class LanguageManager
    {
        public Dictionary<string, LanguagePack> Languages { get; set; }

        public LanguageManager()
        {
            Languages = new Dictionary<string, LanguagePack>();
        }
    }
}
