using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryEng
{
    // Claudia Hopfl
    // Grzegorz Banasiak
    class Program
    {
        static void Main(string[] args)
        {
            //ProgramController.Menu();
            //Console.ReadLine();

            
            LanguageDetectorClass lang = new LanguageDetectorClass("Yo tengo un gato dorado");
            lang.Detect();
            Console.WriteLine(lang.GetFullNameLanguage());

            Console.ReadKey();
            
        }
    }
}
