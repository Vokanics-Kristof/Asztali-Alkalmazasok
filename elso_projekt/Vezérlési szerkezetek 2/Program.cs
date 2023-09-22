using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vezérlési_szerkezetek_2
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
            Console.Write("Pontszám: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine(negyedik(p));
        }

        #region elso
        static void elso()
        {
            Console.Write("Kérek egy számot: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(is_div(a));
        }

        static bool is_div(int a)
        {
            if(a % 3 == 0)
            {
                return true;
            }
            else if(a %4 == 0)
            {
                return true;
            }
            else if(a % 9 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion elso

        #region masodik
        static void masodik()
        {
            Console.Write("A víz hőmérséklete: ");
            int temp = int.Parse(Console.ReadLine());
            if(temp <= 0)
            {
                Console.WriteLine("A víz halmazállapota: jég");
            }
            else if (temp >= 0 && temp < 100)
            {
                Console.WriteLine("A víz halmazállapota: folyékony");
            }
            else
            {
                Console.WriteLine("A víz halmazállapota: gőz");
            }
        }
        #endregion masodik

        #region harmadik
        static void harmadik()
        {
            Console.Write("Az első pont: ");
            string temp = Console.ReadLine();

            Console.Write("A második pont: ");
            string temp2 = Console.ReadLine();

            temp = temp.Replace("(", "").Replace(")", "").Replace(" ", "");
            temp2 = temp2.Replace("(", "").Replace(")", "").Replace(" ", "");


            Point p1 = new Point(int.Parse(temp.Split(';')[0]), int.Parse(temp.Split(';')[1]));
            Point p2 = new Point(int.Parse(temp2.Split(';')[0]), int.Parse(temp2.Split(';')[1]));

            Console.WriteLine("A két pont közötti távolság: " + dist(p1, p2));
        }
        static double dist(Point p1, Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
        }
        #endregion harmadik

        #region negyedik
        static int negyedik(int pontszam)
        {
            if(pontszam >= 90 && pontszam <= 100)
            {
                return 5;
            }
            else if (pontszam >= 80 && pontszam <= 89)
            {
                return 4;
            }
            else if (pontszam >= 65 && pontszam <= 79)
            {
                return 3;
            }
            else if (pontszam >= 50 && pontszam <= 64)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
        #endregion negyedik
    }
}
