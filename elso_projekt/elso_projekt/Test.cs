using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso_projekt
{
    class Test
    {
        public static int second = 0;
        public void Loading()
        {
            //Setting tha base colors
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            window w = new window();
            w.DrawWindow();

            Console.SetCursorPosition(Console.WindowWidth / 2 - 10, Console.WindowHeight / 2);

            int i = 10;

            while(i > -10)
            {
                if (second != DateTime.UtcNow.Second)
                {
                    Console.Write("a");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - i, Console.WindowHeight / 2);
                    second = DateTime.UtcNow.Second;
                    i--;
                }
            }
            Console.ReadLine();
        }
    }

    class window
    {
        public string Title = "Window";
        public int x = 20;
        public int y = 10;

        public void DrawWindow()
        {
            Console.SetCursorPosition(20, 10);
            for(int i = 0; i < 50; i++)
            {
                Console.Write("+");
            }
            Console.SetCursorPosition(22, 10);
            Console.Write(Title);
            Console.SetCursorPosition(20, 10);
            for (int i = 0; i < 10; i++)
            {
                Console.Write("+");
                Console.SetCursorPosition(x + 50, y);
                Console.Write("+");
                y++;
                Console.SetCursorPosition(x, y);
            }
            for (int i = 0; i < 51; i++)
            {
                Console.Write("+");
            }
        }
    }
}
