﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryEng
{
    class ProgramViews
    {
        public void ShowMenu()
        {
            Console.WriteLine("##########################################");
            Console.WriteLine("#####       English Dictionary       #####");
            Console.WriteLine("#####--------------------------------#####");
            Console.WriteLine("#####         Claudia Hopfl          #####");
            Console.WriteLine("#####       Grzegorz Banasiak        #####");
            Console.WriteLine("##########################################");
            Console.WriteLine("");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Tlumacz slowek");
            Console.WriteLine("2. Slowka");
            Console.WriteLine("3. O Programie");
            Console.WriteLine("4. Zamknij");

            ChooseAction();

        }

        private void ChooseAction()
        {
            String actionNumber;

            Console.WriteLine(" ");
            Console.Write("Wpisz kod dzialania: ");
            actionNumber = Console.ReadLine();
            CheckActionNumberForMenu(actionNumber);
        }

        private void CheckActionNumberForMenu( String actionNumber )
        {
            switch (actionNumber)
            {
                case "1":
                    Console.WriteLine(actionNumber);
                    break;
                case "2":
                    Console.WriteLine(actionNumber);
                    break;
                case "3":
                    Console.WriteLine(actionNumber);
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
