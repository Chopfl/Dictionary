using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryEng
{
    static class ProgramController
    {

        //Akcja widok menu w w kontrolerze program
        public static void Menu()
        {
            ProgramViews programViews = new ProgramViews();
            programViews.ShowMenu();
        }

        //Akcja widok o programie w kontrolerze program
        public static void About()
        {
            ProgramViews programViews = new ProgramViews();
            programViews.ShowAbout();
        }
    }
}
