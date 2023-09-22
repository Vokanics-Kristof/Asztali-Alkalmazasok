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
            elso();
        }

        static void elso()
        {
            Console.Write("Kérek egy számot: ");
            double a = double.Parse(Console.ReadLine());
            
            Console.Write("Kérek mégegy számot: ");
            double b = double.Parse(Console.ReadLine());

            if(a > b)
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
    }
}
