using System;
using System.Collections.Generic;

namespace lab1
{
    class Search
    {
        int year { get; set; }
        string name { get; set; }
        int diameter { get; set; }
        int frequency { get; set; }

        public Search() { }

        ~Search() { }

        List<Search> list = new List<Search>();

        public void Input()
        {
            string x;
            Console.WriteLine("");
            Console.WriteLine("Щоб додати ще данi введiть y, в iншому випадку введiть будь-що окрiм y");
            Console.WriteLine("");
            do
            {
                Console.WriteLine("Заповнення:");
                list.Add(new Search()
                { 
                    year = Convert.ToInt16(Console.ReadLine()),
                    name = Console.ReadLine(),
                    diameter = Convert.ToInt16(Console.ReadLine()),
                    frequency = Convert.ToInt16(Console.ReadLine())
                });
                Console.WriteLine("");
                Console.Write("Додати ще? ");
                x = Console.ReadLine();
                Console.WriteLine("");
            }
            while (x == "y");
        }

        public void Output()
        {
            Console.WriteLine(String.Format("{0,20}|{1,20}|{2,20}|{3,20}", "Рiк ", "Науковий керiвник ", "Дiаметр антени (м) ", "Робоча частота (Мгц)" ));
            foreach (Search s in list)
            {
                Console.WriteLine(String.Format("{0,20}|{1,20}|{2,20}|{3,20}", s.year, s.name, s.diameter, s.frequency));
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Search s = new Search();
            s.Input();
            Console.WriteLine("");
            s.Output();
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
