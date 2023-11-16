using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Cikl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Feladat1();

            //Feladat2();

            //Feladat3();//Switch-Case

            //Feladat4();

            //Feladat5();
            //Ciklusok 2
            Feladat6();

            //Math
        }

        static void Feladat1()
        {
            Console.WriteLine();
            int osszeg = 0;
            int beker = int.Parse(Console.ReadLine());
            for(int i = 1; i <= beker; i++)
            {
                if(beker%i == 0)
                {
                    Console.Write(i+",");
                    osszeg += i;
                }
            }
        }

        static void Feladat2()
        {
            Console.WriteLine();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int eredmeny = 1;
            for(int i = 1; i <= y; i++)
            {
                eredmeny = eredmeny * 2;
            }
            Console.WriteLine(eredmeny);
            Console.ReadLine();

            Console.WriteLine("Adj meg egy számot és megmondom, hogy tökéletes-e: ");
            int osszeg = 0;
            int beker = int.Parse(Console.ReadLine());
            for (int i = 1; i <= beker; i++)
            {
                if (beker % i == 0)
                {
                    osszeg += i;
                }
            }
            if(osszeg == beker * 2)
            {
                Console.WriteLine("A szám tökéletes");
            }
            else
            {
                Console.WriteLine("A szám nem tökéletes");
            }
            Console.ReadLine();
        }

        static void Feladat3()
        {
            //switch-case

            Console.Write("Adj meg egy számot és megmondom az melyik nap (1-7): ");
            int napszam = int.Parse(Console.ReadLine());

            switch(napszam)
            {
                case 1:
                    Console.WriteLine("Hétfő van");
                    break;
                case 2:
                    Console.WriteLine("Kedd van");
                    break;
                case 3:
                    Console.WriteLine("Szerda van");
                    break;
                case 4:
                    Console.WriteLine("Csütörtök van");
                    break;
                case 5:
                    Console.WriteLine("Péntek van");
                    break;
                case 6:
                    Console.WriteLine("Szombat van");
                    break;
                case 7:
                    Console.WriteLine("Vasárnap van");
                    break;
                default: 
                    Console.WriteLine("Not a valid day number");
                    break;
            }
            Console.ReadKey();
        }

        static void Feladat4()
        {
            Console.WriteLine();

            string name = Console.ReadLine();

            switch(name)
            {
                case "A":
                    Console.WriteLine($"Hi! {name}");
                    break;
                case "B":
                    Console.WriteLine($"Hi! {name}");
                    break;
                case "C":
                    Console.WriteLine($"Hi! {name}");
                    break;
                case "D":
                    Console.WriteLine($"Hi! {name}");
                    break;
            }
        }

        static void Feladat5()
        {
            //if-else
            int left = int.Parse(Console.ReadLine());
            string operat = Console.ReadLine();
            int right = int.Parse(Console.ReadLine());

            if(operat == "+")
            {
                Console.WriteLine(left + right);
            }
            else if (operat == "-")
            {
                Console.WriteLine(left - right);
            }
            else if (operat == "*")
            {
                Console.WriteLine(left * right);
            }
            else if (operat == "/")
            {
                Console.WriteLine(left / right);
            }
            else
            {
                Console.WriteLine("Not a valid operator!");
            }

            switch (operat)
            {
                case "+":
                    Console.WriteLine(left + right);
                    break;
                case "-":
                    Console.WriteLine(left - right);
                    break;
                case "*":
                    Console.WriteLine(left * right);
                    break;
                case "/":
                    Console.WriteLine(left / right);
                    break;
                default:
                    Console.WriteLine("Not a valid operator!");
                    break;
            }

            Console.ReadKey();
        }

        static void Feladat6()
        {
            int playerX = 20;
            int playerY = 20;
            a:
            for(int i = 0; i < Console.WindowHeight; i++)
            {
                for(int j = 0; j < Console.WindowWidth; j++)
                {
                    if(j == playerX || j == playerX + 1 || i == playerY)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("█");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("█");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            Console.CursorVisible = false;
            goto a;

            //While ugyanígy meg lehet oldani
            Console.ReadKey();
        }
    }
}
