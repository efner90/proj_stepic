using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Наследование
{
    class BaseClass
    {
        public int publicField;
        private int PrivateField;
        protected int protectedField;

        public void PublicMethod()
        {
            Console.WriteLine(publicField);
            Console.WriteLine(PrivateField);
            Console.WriteLine(protectedField);
        }
    }

    class DeviredClass : BaseClass
    {
        public int anotherPublicField;

        public void AnotherPublicMethod()
        {
            Console.WriteLine(publicField);
            //Console.WriteLine(PrivateField); нет доступа
            Console.WriteLine(protectedField);
            Console.WriteLine(anotherPublicField);
        }
    }
    
    class _1lesson
    {
        static void Mainx(string[] args)
        {
            var obj = new DeviredClass();
            Console.WriteLine(obj.publicField);
            //протектет и приват так же недоступны
            Console.WriteLine(obj.anotherPublicField);
        }
        

    }
}
