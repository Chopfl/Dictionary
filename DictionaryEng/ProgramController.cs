using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryEng
{
    class ProgramController
    {
        public static void Menu()
        {
            ProgramViews programViews = new ProgramViews();
            programViews.ShowMenu();
        }
    }
}
