using System;

namespace Lucktext
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            Console.WriteLine("Skriv ett adjektiv");
            string a1 = Console.ReadLine();
            Console.WriteLine("Skriv ett adjektiv");
            string a2 = Console.ReadLine();
            System.Console.WriteLine("Skriv ett namn");
            string a3 = Console.ReadLine();
            System.Console.WriteLine("Skriv ett yrke");
            string a4 = Console.ReadLine();
            System.Console.WriteLine("Skriv ett verb");
            string a5 = Console.ReadLine();
            System.Console.WriteLine("skriv ett namn");
            string a6 = Console.ReadLine();
            System.Console.WriteLine("Skriv en åldersgrupp");
            string a7 = Console.ReadLine();
            System.Console.WriteLine("skriv en fritidsaktivitet");
            string a8 = Console.ReadLine();
            System.Console.WriteLine("Skriv ett djur");
            string a9 = Console.ReadLine();
            start = 1;

            if (start == 1)
            {
                System.Console.WriteLine("Hej jag heter " + a3 + " och jag jobbar som " + a4 + ". \n" +
                "Jag har " + a1 + " hår och " + a2 + " ögon, på fritiden är jag med " + a7 + " i parken där vi " + a5 + " och " + a8 + ". \n" +
                "På kvällen så är med min " + a9 + " " + a6 + ".");

            }

            Console.ReadLine();


        }
    }
}
