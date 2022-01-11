using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Исключения
{
    class MyExeption : Exception
    {
        public int AdditionalData { get; set; }
    }
    
    class Try_catch_fin
    {
        static void Method0()
        {
            throw new MyExeption() { AdditionalData = 123 };
        }

        static void Method1()
        {
            Console.WriteLine("Inside Method1");
            Method0();
        }

        static void Method2()
        {
            try
            {
                Console.WriteLine("Inside try");
                Method1();
            }
            catch (Exception e)
            {
                Console.WriteLine("Inside catch", e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("inside finally");
            }            
        }

        static void MainX()
        {
            Method2();
        }
    }
}
