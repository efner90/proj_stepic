using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic
{
    class TestedClass
    {
        public string field = "значениеполя не изменено";
    }
    struct MyStruct
    {
        public string field; 
    }
    
    class Структуры
    {
        public static void UpdateClass(TestedClass c)
        {
            c.field = "значение поля изменено";
        }

        public static void UpdateStructWrong(TestedClass s)
        {
            s.field = "значеине поля изменено";
        }

        public static void UpdateStructCorrect (ref MyStruct s)
        {
            s.field = "значение поля изменено";
        }

        public static MyStruct UpdateStructPerfect(MyStruct s)
        {
            return new MyStruct { field = "значение поля изменено" };
        }

        public static void Mainx ()
        {
            var c = new TestedClass();
            UpdateClass(c);
            Console.WriteLine(c.field);

            var s = new MyStruct() { field = "значение поля не изменено" };
            //			UpdateStructWrong(s);
            UpdateStructCorrect(ref s);
            s = UpdateStructPerfect(s);
            Console.WriteLine(s.field);
        }
    }
}
