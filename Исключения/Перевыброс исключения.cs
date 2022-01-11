using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Исключения
{
    class AlgorithmExeption : Exception
    {
        public AlgorithmExeption(Exception innerExeption)
            : base("", innerExeption)
        { }

        public AlgorithmExeption()
            : this(null)
        { }
    }


    class Перевыброс_исключения
    {
        static string Method (string argument)
        {
            try
            {
                var n = int.Parse(argument);
                return (2 * n).ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("Do some interesting...");

                //return null;
                //throw;
                //throw e;
                //throw new AlgorithmExeption();
                throw new AlgorithmExeption(e);
            }
        }
        static void PrintExeption(Exception e)
        {
            Console.WriteLine(e.GetType() + "\n");
            Console.WriteLine(e.Message + "\n");
            Console.WriteLine(e.StackTrace + "\n");

            if (e.InnerException != null)
                PrintExeption(e.InnerException);
        }

        static void MainX()
        {
            try
            {
                Method("abc");
            }
            catch (AlgorithmExeption e)
            {
                PrintExeption(e);
            }
        }
    }
}
