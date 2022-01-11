using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Делегаты
{
    class Welcome
    {
        public static void Print() => Console.WriteLine("Welcome");
    }

    class Hello
    {
        public static void Display() => Console.WriteLine("Привет");
    }
    class Delegate_Metanit
    {
        delegate void Message(); //1 объявляем делеагт
        public static void MainX()
        {
            Message mes; //2 создаём переменную делегата
            Message message1 = Welcome.Print;
            //Message message2 = new Hello().Display;
            mes = Hello; //3 Присваиваем этой переменной адрес метода
            mes(); //4 вызываем метод
            message1();
            //message2();

            void Hello() => Console.WriteLine("Hello biatch");
        }
    }
}
