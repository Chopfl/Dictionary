using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryEng
{
    class DetectorViews : IChoosable
    {
        String textToDetected = null;

        public void ShowDetectorIndex()
        {
            Console.Clear();

            Console.WriteLine("##########################################");
            Console.WriteLine("##########   Detektor językowy  ##########");
            Console.WriteLine("##########################################");
            Console.WriteLine(" ");
            Console.WriteLine("  Napisz slowo lub zdanie, a nastepnie");
            Console.WriteLine("  zatwierdź w celu wykrycia języka");
            Console.WriteLine(" ");
            Console.Write("  Wpisz tekst: ");
            textToDetected = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine(" Tekst do sprawdzenia to: " + textToDetected);

            ChooseAction();
        }

        public void ShowDetectedLanguage(String language, String text)
        {
            Console.Clear();

            Console.WriteLine("##########################################");
            Console.WriteLine("##########   Detektor językowy  ##########");
            Console.WriteLine("##########################################");
            Console.WriteLine(" ");
            Console.WriteLine(" Tekst: " + text);
            Console.WriteLine(" Jest w jezyku: " + language);
            Console.WriteLine(textToDetected);

            ChooseAction();
        }

        public void ChooseAction()
        {
            String actionNumber;

            Console.WriteLine("");
            Console.WriteLine("################  Menu  #################");
            Console.WriteLine("1. Sprawdz co to za jezyk ");
            Console.WriteLine("    ------   ");
            Console.WriteLine("2. Sprawdz inny tekst");
            Console.WriteLine("3. Menu");
            Console.WriteLine(" ");
            Console.Write("Wpisz kod dzialania: ");
            actionNumber = Console.ReadLine();
            CheckActionNumber(actionNumber);
        }

        public void CheckActionNumber(String actionNumber)
        {
            switch (actionNumber)
            {
                case "1":
                    DetectorController.DetectLanguage(textToDetected);
                    break;
                case "2":
                    DetectorController.DetectorIndex();
                    break;
                case "3":
                    ProgramController.Menu();
                    break;
                default:
                    Console.WriteLine(" ");
                    Console.WriteLine("##### Dokonales blednego wyboru! #####");
                    ChooseAction();
                    break;
            }
        }
    }
}
