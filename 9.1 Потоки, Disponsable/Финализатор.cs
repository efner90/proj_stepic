using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic._9._1_Потоки__Disponsable
{
    public class Финализатор
    {
        int number;
        byte[] memory = new byte[100000000];

        static object lockObj = new object();

        public Финализатор (int number)
        {
            this.number = number;
            lock (lockObj)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Object {0,2} is created", number);
            }
        }

        ~Финализатор() // финализатор - метод, который вызывается при сборке мусора
        {
            lock(lockObj)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Object {0,2} is disposed", number);
            }
        }

    class Programator
    {
        public static void MainX()
        {
                for (int i = 0; i < 10; i++)
                    new Финализатор(i);
        }
    }
    }
}
