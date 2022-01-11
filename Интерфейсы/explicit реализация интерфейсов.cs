using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Интерфейсы
{
    interface IInterface1
    {
        void Method();
    }

    interface IInterface2
    {
        void Method();
    }

    public class ClassII : IInterface1, IInterface2
    {
        public void Method()
        {
            Console.WriteLine("Interface1");
        }

        void IInterface2.Method()
        {
            Console.WriteLine("Interface2");
        }
    }
    
    class explicit_реализация_интерфейсов
    {
        static void MainX()
        {
            var obj = new ClassII();
            obj.Method();
            (obj as IInterface1).Method();
            (obj as IInterface2).Method();
        }
    }
}
