using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Generics
{
    public class Person { }
    public class Employee : Person { }
    public class Manager : Employee { }

    public class Processor<T>
    {
        public T GetByID(int ID) { throw new NotImplementedException(); }
        public void Save (T obj) { throw new NotImplementedException(); }
    }
    
    class Инвариантность
    {
        public static void MainX()
        {
            var p = new Processor<Employee>();
            Console.WriteLine(p is Processor<Employee>); //true
            Console.WriteLine(p is Processor<Person>); // false
            Console.WriteLine(p is Processor<Manager>); //false
        }
    }
}
