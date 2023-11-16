using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szam = 0;
            Console.WriteLine("dfiofh" + szam.ToString());

            //Feladat1();
            //Feladat2();
            Szamkitalalas();
        }

        static void Feladat1()
        {
            string nev = "";
            while(nev == "" || nev == "Shakespeare")
            {
                Console.Write("Kérek egy nevet: ");
                nev = Console.ReadLine();
            }

            Console.ReadLine();
        }

        static void Feladat2()
        {
            Random r = new Random();
            int szam = r.Next(0, 101);
            Console.WriteLine(szam);

            double szam2 = r.NextDouble();
            Console.WriteLine(szam2);

            int veletlen = r.Next(0, 2);
            bool logikai = true;
            if(veletlen == 0)
            {
                logikai = false;
            }
            Console.WriteLine(logikai);

            char c = (char)r.Next('A', 'Z' + 1);
            Console.WriteLine(c);

            Console.ReadLine();
        }

        static void Szamkitalalas()
        {
            Random r = new Random();
            int gondolt = r.Next(0, 101);

            int tipp;

            bool talalt = false;

            int i = 0;

            while(talalt == false)
            {
                i++;
                Console.Write("tipp: ");
                tipp = int.Parse(Console.ReadLine());
                if(gondolt > tipp)
                {
                    Console.WriteLine("A gondolt szám nagyobb");
                }
                else if(gondolt < tipp)
                {
                    Console.WriteLine("A gondolt kisebb nagyobb");
                }
                else
                {
                    talalt = true;
                    Console.WriteLine($"Eltaláltad {i} próbálkozás után");
                }
            }
        }
    }
}
