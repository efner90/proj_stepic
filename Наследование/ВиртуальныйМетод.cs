using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Наследование
{
    class BaseClas
    {
        public virtual void Print()
        {
            Console.WriteLine("Base clas");
        }
    }

    class DeviredClas : BaseClas
    {
        public override void Print()//заменяет навсегда
        {
            //base.Print();//отрабатывает базовай класс
            Console.WriteLine("Devired Clas");
        }
    }
    
    class ВиртуальныйМетод
    {
        static void MainX()
        {
            var baseObj = new BaseClas();
            baseObj.Print();

            var devireObj = new DeviredClas();
            devireObj.Print();

            var devireAsBase = (BaseClas)devireObj; //upcast
            devireAsBase.Print();

            var baseObj1 = new BaseClas();
            baseObj1.Print();
        }
    }
}
