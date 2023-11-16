using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            while(j < 10)
            {
                Console.Write(j + ",");
                j++;
            }
            
            j = 10;
            while (j >= 0)
            {
                Console.Write(j + ",");
                j--;
            }

            j = 10;
            while (j >= 0)
            {
                Console.Write(j + ",");
                j -= 2;
            }

            string szoveg = "";
            while(szoveg == "")
            {
                Console.Write("Adj meg valamit: ");
                szoveg = Console.ReadLine();
            }

            int k = 5;
            do
            {
                k++;
            }
            while (k < 5);

            Console.WriteLine(k);

            k = 20;
            do
            {
                Console.Write(k + ",");
                k--;
            }
            while (k > 0);
            k = 20;
            do
            {
                Console.Write(k + ",");
                k--;
            }
            while (k > 0);

            szoveg = "";
            do
            {
                szoveg = Console.ReadLine();
            }
            while (szoveg == "");
        }
    }
}
