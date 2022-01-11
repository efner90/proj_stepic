using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Generics
{
    class Person<T,K> //T универсальный параметр, может быть любым, инт стринг и тд
    {
        public static T code;
        public T Id { get; set; }
        public K Password { get; set; }
        public string Name { get; set; }
        public Person (T id, string name, K password)
        {
            Id = id;
            Name = name;
            Password = password;
        }
    }

    class Company<P>
    {
        public P CEO { get; set; } //president
        public Company(P ceo)
        {
            CEO = ceo;
        }
    }
    
    class Обобщенные_типы_Metenit
    {
        public static void MainX()
        {
            Person<int,string> tom = new Person<int,string>(543, "Tom", "qwe123"); //упаковка не нужна
            //Person<int>.code = 1234;

            Person<string,int> bob = new Person<string,int>("abc123", "Bob", 123);
            Person<string,int>.code = "meta";

            Company<Person<int,string>> microsoft = new Company<Person<int,string>>(tom);

            int tomId = (int)tom.Id; //не нужна распаковка
            string bobId = (string)bob.Id; //преобразование тоже не нужно

            Console.WriteLine(tomId);
            Console.WriteLine(bobId);
            Console.WriteLine(bob.Name);
            Console.WriteLine(tom.Password);
            //Console.WriteLine(Person<int>.code);
            //Console.WriteLine(Person<string>.code);

            int x = 7;
            int y = 25;
            Swap<int>(ref x, ref y);
            Console.WriteLine($"x={x} y={y}"); //x=25;y=7

            string s1 = "hello";
            string s2 = "bye";
            Swap<string>(ref s1, ref s2);
            Console.WriteLine($"s1={s1} s2={s2}"); //s1 = bye, s2 = hello

            void Swap<T>(ref T x, ref T y)
            {
                T cash = x;
                x = y;
                y = cash;
            }
        }
    }
}
