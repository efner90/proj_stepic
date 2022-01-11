using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Исключения
{
    class Глобальная_отработка
    {
        static void Method1()
        {
            Console.WriteLine("Method 1");
            throw new Exception();
        }

        static void MainX()
        {
            AppDomain.CurrentDomain.UnhandledException += ProcessExeption;

            Method1();
        }

        static void ProcessExeption(object sender, UnhandledExceptionEventArgs args)
        {
            Console.WriteLine((args.ExceptionObject as Exception).StackTrace);
            Environment.Exit(1);
        }
    }
}
