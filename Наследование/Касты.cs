using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Наследование
{
    public class Person { }    

    public class Client : Person { }

    public class Employee : Person { }
        
    class Касты
    {
        public static void MainX()
        {
            var client = new Client();
            Person person = new Person();
            Employee employee = new Employee();

            Console.WriteLine(client is Person);
            Console.WriteLine(person is Person);
            Console.WriteLine(client is Client);
            Console.WriteLine(person is Client); //false
            Console.WriteLine(employee is Client); // false

            var clientAsPerson = client;
            Console.WriteLine(clientAsPerson is Client); //true
            var correctClient1 = clientAsPerson as Client; //downcast
            var correctClient2 = (Client)clientAsPerson;

            var incorrectClient = person as Client; // = null
            //var incorrectClient2 = (Client)person; //выкинет исключение, person != client
            //Client incorrectClient3 = (Client)employee - невозможно



        }
    }
}
