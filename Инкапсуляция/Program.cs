using System;

namespace proj_stepic
{
    public class MyClass
    {
        public int PublicField; //объявление поля
        private int privateField; //приватное поле
        public static int PubStatField;

        public void PublicMethod()
        {
            Console.WriteLine(PublicField);
            Console.WriteLine(privateField);
            Console.WriteLine(PubStatField);
            PrivateMethod();    
        }

        private void PrivateMethod() { }

        public static void PubStatMethod()
        {
            //нельзя обращаться к нестатическому поля из статического
            //Console.WriteLine(publicField);
            //Console.WriteLine(privateField);

            Console.WriteLine(PubStatField);
        }
    }
    
    class Program
    {
        static void MainX(string[] args)
        {
            var obj = new MyClass(); //объект класса Мойкласс
            obj.PublicField = 1;
            obj.PublicMethod();
            //нельзя обращаться к приватным членам класса извне класса
            //obj.privateField = 1;
            //obj.PrivateMethod();

            MyClass.PubStatField = 1; //объявление через имя класса
            MyClass.PubStatMethod();

            //нельзя обращаться к нестатическим чтенам через имя класса
            //MyClass.publicFiled = 1;
            //MyClass.PublicMethod();

            //нельзя обращаться к статически членам через имя объекта
            //obj.pubStatField = 1;
            //obj.PubStatMethod();
        }
    }
}
