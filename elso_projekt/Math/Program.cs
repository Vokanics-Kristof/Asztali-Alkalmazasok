using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elso();
        }

        static void Elso()
        {
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Abs(-5));
            Console.WriteLine(Math.Sqrt(16));
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Min(2, 3));
            Console.WriteLine(Math.Max(2, 3));
            double szam = 10.125;

            Console.WriteLine(Math.Round(szam, 0));
            Console.WriteLine(Math.Round(szam, 2));

            Console.WriteLine(Math.Ceiling(szam));//Felfelé
            Console.WriteLine(Math.Floor(szam));//Lefelé

            int a = 22;
            int b = 13;
            int c = -6;

            if((Masodfoku(a, b, c) == null))
            {
                Console.WriteLine("Az egyenletnek nincs megoldása!");
            }
            else if((Masodfoku(a, b, c).Count == 1))
            {
                Console.WriteLine(Masodfoku(a, b, c)[0].ToString());
            }
            else
            {
                Console.WriteLine(Masodfoku(a, b, c)[0].ToString() + ", " + Masodfoku(a, b, c)[1].ToString());
            }

            Console.ReadLine();
        }

        static List<double> Masodfoku(int a, int b, int c)
        {
            List<double> d = new List<double>();
            if(Math.Pow(b, 2) - 4 * a * c > 0)
            {
                double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                d.Add(x1);

                double x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                d.Add(x2);
            }
            else if(Math.Pow(b, 2) - 4 * a * c == 0)
            {
                double x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
                d.Add(x1);
            }
            else
            {
                return null;
            }

            return d;
        }
    }
}
