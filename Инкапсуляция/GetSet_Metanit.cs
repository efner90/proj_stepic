using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Инкапсуляция
{
    /*[модификаторы] тип_свойства название_свойста
     * {
     *      get {действия, выполняемые при получении значения свойства}
     *      set {действия, выполняемые при установке значения свойства}
     */
    class Person
    {
        private string name = "Undefined";

        public string Name
        {
            get { return name; } //возвращаем значение свойства
            set { name = value; } //устанавливаем новое значение свойства
        }

        int age = 1;
        public int Age
        {
            set
            {
                if (value <1 || value>120)
                    Console.WriteLine("Возраст должен быть в диапазоне от 1 до 120");
                else
                    age = value;
            }
            get { return age; }
        }

    } 
    
    class Person2
    {
        string name = "Tom";
        int age = 1;
        //свойство только для записи
        public int Age
        {
            set { age = value; }
        }
        //свойство только для чтения
        public string Name
        {
            get { return name; }
        }

        public void Print() => Console.WriteLine($"Name : {name},  Age: {age}");
    }

    class Person3
    {
        //в данном случае класс имеет свойство Namе,которое доступно только для чтения и
        //которое возвращает общее значение переменных
        string firstName;
        string lastName;
        public string Name
        {
            get { return $"{firstName} {lastName}"; }
        }
        public Person3 (string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }

    class Person1
    {
        string name = "";
        public string Name
        {
            get { return name; }

            private set { name = value; } //сможемиспользовать только в классе
        }
        public Person1(string name) => Name = name;
    }

    class Person4
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person4 (string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Person5
    {
        public Person5()
        {
        }

        public Person5(string name) => Name=name;
        public string Name { get; init; } //= "Undefined";
    }

    class Person6
    {
        string name;
        public string Name
        {
            get => name;//сокращенное написание
            set => name = value;
        }
        public string lastName => name;
        //эквивалентно
        //public string Name { get { return name; } }
    }
    

    internal class GetSet_Metanit
    {
        static void MainX(string[] args)
        {
            Person5 person5 = new();
            //person5.Name = "Bob"; после инициализации изменить значение нельзя
            Console.WriteLine(person5.Name);
            
            Person person = new Person();
            //устанавливаем свойство - срабатывает блок Сет
            //значение Том и есть передаваемое в свойство value
            person.Name = "Tom";

            //получаем значение свойства и присваиваем его переменной - срабатывает Get
            string personName = person.Name;
            Console.WriteLine(personName);

            var person1 = new Person();
            Console.WriteLine(person1.Age); //1
            //изменяем значение свойства

            person1.Age = 37;
            Console.WriteLine(person1.Age); //37

            //пробуем передать недопустимое значение
            person1.Age = -23;
            Console.WriteLine(person1.Age);

            Person2 person2 = new Person2();

            //свойство для чтения - можно получить значение
            Console.WriteLine(person2.Name); //Tom
            //но нельзя установить
            //person2.Name = "Bob"; выдаёт ошибку

            //свойство для записи - можно установить значение
            person2.Age = 37;
            //но нельзя получить
            //Console.WriteLine(person2.Age); ошибка

            person2.Print();
        }
    }
}
