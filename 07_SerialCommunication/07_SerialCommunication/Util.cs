using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_SerialComunication
{
    class Util
    {
        public static void Write(int x, int y, String text)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(text);
        }

        public static void Write(int x, int y, String text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Write(x, y, text);
            Console.ResetColor();
        }

        public static void Write(String text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }

        public static ConsoleKeyInfo ReadAnonymous()
        {
            Console.ForegroundColor = Console.BackgroundColor;
            ConsoleKeyInfo input = Console.ReadKey();
            Console.ResetColor();

            return input;
        }
    }
}
