using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic
{
    class МетодыПрмтрПоУмолчанию
    {
        public static void Print(string text, ConsoleColor foreColor, ConsoleColor backColor)
        {
            Console.ForegroundColor = foreColor;
            Console.BackgroundColor = backColor;
            Console.WriteLine(text);
        }

        public static void Print (string text, ConsoleColor foreColor)
        {
            Print(text, foreColor, ConsoleColor.Black);
        }

        public static void Print (string text)
        {
            Print(text, ConsoleColor.Gray, ConsoleColor.Black);
        }

        public static void NewPrint(
            string text,
            ConsoleColor foreColor = ConsoleColor.White,
            ConsoleColor backColor = ConsoleColor.Black)
        {
            Console.ForegroundColor = foreColor;
            Console.BackgroundColor = backColor;
            Console.WriteLine(text);
        }

        public static void MainX()
        {
            Print("some text here", ConsoleColor.Yellow, ConsoleColor.Blue);
            Print("some text here", ConsoleColor.Yellow);
            Print("some text here");
            Console.WriteLine();

            NewPrint("some text here", ConsoleColor.Yellow, ConsoleColor.Blue);
            NewPrint("some text here", ConsoleColor.Yellow);
            NewPrint("some text here");
            NewPrint("some text here", backColor: ConsoleColor.Blue);
        }
    }
}
