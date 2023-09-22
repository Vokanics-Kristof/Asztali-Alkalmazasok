using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            elso();
            masodik();
            harmadik();
            negyedik();
        }

        #region elso
        static void elso()
        {
            Console.Write("A téglalap a oldala: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("A téglalap b oldala: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine($"A téglalap kerülete: {Ker(a, b)}, területe: {Ter(a, b)}");
        }
        static float Ker(float a, float b)
        {
            return (int)(a + b) * 2;
        }
        static float Ter(float a, float b)
        {
            return (int)(a * b);
        }
        #endregion elso

        #region masodik
        static void masodik()
        {
            Console.Write("Az egyenlet: ");
            string num = Console.ReadLine();

            num = num.Replace(" ", "");

            if (num.Contains("+"))
            {
                string[] szamok = num.Split('+');

                Console.WriteLine(int.Parse(szamok[0]) + int.Parse(szamok[1]));
            }
            else if (num.Contains("-"))
            {
                string[] szamok = num.Split('-');

                Console.WriteLine(int.Parse(szamok[0]) - int.Parse(szamok[1]));
            }
            else if (num.Contains("*"))
            {
                string[] szamok = num.Split('*');

                Console.WriteLine(int.Parse(szamok[0]) * int.Parse(szamok[1]));
            }
            else if (num.Contains("/"))
            {
                string[] szamok = num.Split('/');

                Console.WriteLine(int.Parse(szamok[0]) / int.Parse(szamok[1]));
            }
        }
        #endregion masodik

        #region harmadik
        static void harmadik()
        {
            Console.Write("Celsius: ");
            float num = float.Parse(Console.ReadLine());
            Console.WriteLine($"Ugyanez Fahrenheitben: {Fahrenheit(num)}");
        }
        static float Fahrenheit(float cels)
        {
            return cels * 9 / 5 + 32;
        }
        #endregion harmadik

        #region negyedik
        static void negyedik()
        {
            Console.Write("A kör rádiusza: ");
            float rad = float.Parse(Console.ReadLine());
            Console.WriteLine($"A téglalap területe: {Circe_T(rad)}, kerülete: {Circe_K(rad)}");
        }
        static double Circe_T(float rad)
        {
            return Math.PI * Math.Pow(rad, 2);
        }
        static double Circe_K(float rad)
        {
            return 2 * Math.PI * rad;
        }
        #endregion negyedik
    }
}
