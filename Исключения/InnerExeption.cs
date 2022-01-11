using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Исключения
{
    class NyClass
    {
        static NyClass()
        {
            var n = int.Parse("abc");
        }
    }
    
    class InnerExeption
    {
        static void MainX()
        {
            Console.WriteLine("Main begin");
            var e = new NyClass();
        }
    }
}
