using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Исключения
{
    class Однострочный_try
    {
        static void MainX() //отловить не приципиальный параметр v
        {
            int notTmportParam;
            try
            {
                notTmportParam = int.Parse(File.ReadAllText("test.txt"));
            }
            catch
            {
                notTmportParam = 1;
            }
        }
    }
}
