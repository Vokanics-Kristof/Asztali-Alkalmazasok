﻿using System;

namespace Valtozok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int szam; --> inicializálás (létrehozás)
            //szam = 10; --> deklarálás (értékadás)

            //egész szám
            int szam = 10;
            Console.WriteLine(szam);

            //valós szám
            double szam2 = 10.5;
            Console.WriteLine(szam2);

            //karakter
            char betu = 'd';
            Console.WriteLine(betu);

            //szöveg
            string szoveg = "Helló";
            Console.WriteLine(szoveg);

            //logikai
            bool logikai = true;
            Console.WriteLine(logikai);

            bool eredmeny = 1 > 4;
            bool eredmeny2 = 4 > 1 && 2 > 5;
            bool eredmeny3 = 4 > 1 || 2 > 5;

            Console.WriteLine(eredmeny);

            //Speciális karakterek:

            //tabulátor \t
            Console.WriteLine("\talma");

            //sortörés \n
            Console.WriteLine("alma\nkörte");

            //sípszó \a
            Console.WriteLine("\aalma");

            //idézőjel
            Console.WriteLine("A programozás \"szuper\"");

            //aposztróf
            Console.WriteLine("A programozás \'szuper\'");

            //backslash
            Console.WriteLine("A programozás \\szuper\\");

            Console.ReadLine();

        }
    }
}