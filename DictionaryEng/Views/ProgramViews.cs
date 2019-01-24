using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryEng
{
    class ProgramViews : IChoosable
    {
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("##########################################");
            Console.WriteLine("#####       English Dictionary       #####");
            Console.WriteLine("#####--------------------------------#####");
            Console.WriteLine("#####         Claudia Hopfl          #####");
            Console.WriteLine("#####       Grzegorz Banasiak        #####");
            Console.WriteLine("##########################################");
            

            ChooseAction();
        }

        public void ShowAbout()
        {
            Console.Clear();
            Console.WriteLine("##########################################");
            Console.WriteLine("#####       English Dictionary       #####");
            Console.WriteLine("#####--------------------------------#####");
            Console.WriteLine("   O programie:");
            Console.WriteLine("   Program powstal w celu zaliczenia       ");
            Console.WriteLine("   przedmiotu Programowanie Obiektowe C#   ");
            Console.WriteLine("         na uczelni WSEI Krakow            ");
            Console.WriteLine("");
            Console.WriteLine("   Autorzy projektu: ");
            Console.WriteLine("   1. Claudia Hopfl ");
            Console.WriteLine("   2. Grzegorz Banasiak ");

            ChooseAction();
        }


        public void ChooseAction()
        {
            String actionNumber;

            Console.WriteLine("");
            Console.WriteLine("################  Menu  #################");
            Console.WriteLine("1. Tlumacz slowek");
            Console.WriteLine("2. Detektor");
            Console.WriteLine("3. O Programie");
            Console.WriteLine("4. Zamknij");
            Console.WriteLine(" ");
            Console.Write("Wpisz kod dzialania: ");
            actionNumber = Console.ReadLine();
            CheckActionNumber(actionNumber);
        }

        public void CheckActionNumber( String actionNumber )
        {
            switch (actionNumber)
            {
                case "1":
                    Console.WriteLine(actionNumber);
                    break;
                case "2":
                    DetectorController.DetectorIndex();
                    break;
                case "3":
                    ProgramController.About();
                    break;
                case "4":
                    Environment.Exit(0);
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
