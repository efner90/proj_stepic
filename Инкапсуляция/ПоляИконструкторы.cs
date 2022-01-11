using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic
{
    public class MyClasses
    {
        public int So_znacheniem = 5;
        public int publicInt;
        public readonly int tolkoDlyaChtenuya;
        static public int PubStatInt;
        static public readonly int StatPubRO;

        public MyClasses(int c) //объявляем конструктор
        {
            publicInt = c;
            tolkoDlyaChtenuya = c;
            //статические ридонли поля можно иниц только в стат конструкторе
            //StatPubRO = c;
            PubStatInt = c;
        }

        public MyClasses() //приставивает конструктору выше значение 2
        : this(2)
        { }

        void Method()
        {
            //полю Ридонли присваивают значение ток в объявлении
            //tolkoDlyaChtenuya = 1;
        }

        static MyClasses()
        {
            PubStatInt = 1;
            StatPubRO = 1;

            //нельзя обращаться к нестатическому полю из статического метода
            //publicField=1;
            //publicReadonlyField=1;
        }

    }
    
    class ПоляИконструкторы
    {
        public static void MainX()
        {

        }
    }
}
