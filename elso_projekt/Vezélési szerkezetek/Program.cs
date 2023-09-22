using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezélési_szerkezetek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Feladat");
            elso();

            Console.WriteLine("2. Feladat");
            masodik();

            Console.WriteLine("3. Feladat");
            harmadik();

            Console.WriteLine("4. Feladat");
            negyedik();

            Console.WriteLine("5. Feladat");
            otodik();

            Console.WriteLine("6. Feladat");
            hatodik();

            Console.WriteLine("7. Feladat");
            hetedik();
        }

        #region elso
        static void elso()
        {
            Console.Write("Kérek egy számot: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Kérek mégegy számot: ");
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"Az {a} a nagyobb.");
            }
            else if (a < b)
            {
                Console.WriteLine($"Az {b} a nagyobb.");
            }
            else
            {
                Console.WriteLine("A két szám egyenlő");
            }
        }
        #endregion elso

        #region masodik
        static void masodik()
        {
            Console.Write("Kérek egy számot: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Kérek mégegy számot: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Kérek mégegy számot: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"A legkisebb szám {min(a, b, c)}");
        }
        static double min(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
        #endregion masodik

        #region harmadik
        static void harmadik()
        {
            Console.Write("A oldal: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("B oldal: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("C oldal: ");
            int c = int.Parse(Console.ReadLine());

            if(a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("A háromszög szerkeszthető");
            }
            else
            {
                Console.WriteLine("A háromszög nem szerkeszthető");
            }
        }
        #endregion harmadik

        #region negyedik
        static void negyedik()
        {
            Console.Write("A szám: ");
            int a = int.Parse(Console.ReadLine());
            switch (a % 2)
            {
                case 0:
                    Console.WriteLine("A szám páros");
                    break;
                default:
                    Console.WriteLine("A szám nem páros");
                    break;
            }
        }
        #endregion negyedik

        #region otodik
        static void otodik()
        {
            Console.Write("A hőmérséklet (Celsius): ");
            int a = int.Parse(Console.ReadLine());
            if(a >= 10)
            {
                Console.WriteLine("A szobában meleg van");
            }
            else
            {
                Console.WriteLine("A szobában hideg van");
            }
        }
        #endregion otodik

        #region hatodik
        static void hatodik()
        {
            Console.Write("A oldal: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B oldal: ");
            int b = int.Parse(Console.ReadLine());

            if(a == b)
            {
                Console.WriteLine("Az alakzat négyzet");
            }
            else
            {
                Console.WriteLine("Az alakzat téglalap");
            }
        }
        #endregion hatodik

        #region hetedik
        static void hetedik()
        {
            Console.Write("A szám: ");
            double a = double.Parse(Console.ReadLine());

            if(a > 0)
            {
                Console.WriteLine("A szám pozitív");
            }
            else if(a < 0)
            {
                Console.WriteLine("A szám negatív");
            }
            else
            {
                Console.WriteLine("A szám nulla");
            }
        }
        #endregion hetedik
    }
}
