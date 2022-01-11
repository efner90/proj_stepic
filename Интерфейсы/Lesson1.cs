using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Интерфейсы
{
    interface IUser // набор требований к классу
    {
        static void Method() { } // должен быть быть метод Method пустым void
    }

    interface IAdmin { }

    class User : IUser
    {
        public void Method() { }
    }

    class Admin : User, IAdmin { }
    
    class Lesson1
    {
        static void MainX()
        {
            User user = new User();
            Admin admin = new Admin();

            Console.WriteLine(user is IUser); //true
            Console.WriteLine(user is IAdmin); //false
            Console.WriteLine(admin is IUser);  //true
            Console.WriteLine(admin is IAdmin); //true

            var correctCast1 = admin as IUser;
            var correctCast2 = (IUser)admin;
            var correctCast3 = admin as IUser;

            //var incorrectCast1 = (IAdmin)user; //теоритически возможно, поэтому
                                               //только исключение, но реализуется строкой ниже

            user = admin;
            var incorrectCast2 = (IAdmin)user;

        }
    }
}
