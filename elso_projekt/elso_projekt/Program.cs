using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso_projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Hello world!");
                Console.ReadKey();
             */

            Console.Title = "Program";

            //Háttérszín beállítása + Console.Clear(); Kell!!
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.Write("Helló");
            Console.WriteLine("Világ");

            int terulet = 10;
            int kerulet = 20;

            Console.WriteLine("A kör kerülete: " + 10);
            Console.WriteLine("A kör területe: " + 10);

            Console.WriteLine($"A kör kerülete: {kerulet}, területe: {terulet}");
            Console.WriteLine("A kör kerülete: {0}, kerülete: {1}", kerulet, terulet);

            Console.ReadLine();

            Console.Clear();

            // Háttér és írószín visszaállítása
            Console.ResetColor();
            Console.Clear();

            Console.ReadLine();

            Console.SetCursorPosition(10, 20);
            Console.WriteLine("valami");

            Console.ReadLine();

            Test t = new Test();
            t.Loading();
        }
    }
}
