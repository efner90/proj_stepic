using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic
{
    class Helper
    {
        public static int Report(string str)
        {
            Console.WriteLine(str);
            return 0;
        }
    }

    class ForTest
    {
        static int StaticInt = Helper.Report("2. Инициализация статических полей");

        static ForTest()
        {
            Helper.Report("3. Статический конструктор");
        }

        int field = Helper.Report("4. Инициализация нестатических полей");

        public ForTest(int c)
        {
            Helper.Report("5. Конструктор, вызванный другим конструктором");
        }

        public ForTest()
            :this(1)
        {
            Helper.Report("6. Явно вызванный коструктор");
        }

        public void Method()
        {
            Helper.Report("7. Метод");
        }
    }
    class ПорядокИнициализации
    {
        public static void MainZ()
        {
            Helper.Report("1.Начало программы");
            new ForTest().Method();
        }
    }
}
