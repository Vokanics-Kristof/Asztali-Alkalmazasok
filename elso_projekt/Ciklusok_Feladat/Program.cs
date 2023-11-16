using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklusok_Feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Feladat
            Elso();

            //2. Feladat
            Masodik();

            //3. Feladat
            Harmadik();

            //4. Feladat
            Negyedik();

            //5. Feladat
            Otodik();

            //6. Feladat
            Hatodik();

            //7. Feladat
            Hetedik();
        }

        static void Elso()
        {
            Console.Write("A szám: ");
            int a = int.Parse(Console.ReadLine());

            int i = 0;
            while(i <= a)
            {
                Console.Write(i + " ");
                i++;
            }
            Console.WriteLine();
        }

        static void Masodik()
        {
            Console.Write("A szám: ");
            int a = int.Parse(Console.ReadLine());

            int i = 0;
            while (i <= a)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void Harmadik()
        {
            Console.Write("A szám: ");
            int a = int.Parse(Console.ReadLine());

            int i = 1;
            while (i <= a)
            {
                if(a % i == 0)
                {
                    Console.WriteLine($"Az {i} osztója");
                }
                i++;
            }
        }

        static void Negyedik()
        {
            Console.Write("A szám: ");
            int a = int.Parse(Console.ReadLine());

            int i = 1;
            int temp = 0;
            while (i <= a)
            {
                if (a % i == 0)
                {
                    temp += i;
                }
                i++;
            }
            Console.WriteLine($"A szám osztóinak összege: {temp}");
        }

        static void Otodik()
        {
            Console.Write("A szám: ");
            int a = int.Parse(Console.ReadLine());

            int i = 1;
            int temp = 0;
            while (i <= a)
            {
                if (a % i == 0)
                {
                    temp += i;
                }
                i++;
            }

            if(a * 2 == temp)
            {
                Console.WriteLine("A szám tökéletes");
            }
            else
            {
                Console.WriteLine("A szám nem tökéletes");
            }
        }

        static void Hatodik()
        {
            Console.Write("Alap: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Kitevő: ");
            int k = int.Parse(Console.ReadLine());
            int ertek = 1;

            int j = 0;
            if(a == 0)
            {
                ertek = 0;
            }
            else
            {
                while (j < k)
                {
                    ertek *= a;
                    j++;
                }
            }
            Console.WriteLine($"Hatványérték: {ertek}");
        }

        static void Hetedik()
        {
            int a;
            do
            {
                a = int.Parse(Console.ReadLine());
            } while (a < 0);
        }
    }
}
