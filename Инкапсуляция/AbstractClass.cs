using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Инкапсуляция
{
    abstract class Transport
    {
        public string Name { get; }
        //конструктор абстрактного класса
        public Transport(string name)
        {
            Name = name;
        }

        //public void Move()
        //{           

        //    Console.WriteLine("Транспортное средство движется");
        //}
        //public  void Move() => Console.WriteLine($"{Name} движется ");
        public abstract void Move();
        //абстрактное свойство для хранения скорости
        public abstract int Speed { get; set; }
    }
    class Ship : Transport 
    {
        //конструктор базового класса
        public override void Move()
        {
            Console.WriteLine("Корабль плывёт");
        }
        public Ship (string name)
            : base(name) { }

        int speed;
        public override int Speed //полноценное свойство
        {
            get => speed;
            set => speed = value;
        }
    }

    class Aircraft : Transport 
    {
        public override void Move()
        {
            Console.WriteLine("Самолёт летит");
        }

        public Aircraft(string name)
            :base(name) { }

        int speed; //автосвойство
        public override int Speed { get; set; }

    }

    abstract class Car : Transport 
    {
        //public override void Move()
        //{
        //    Console.WriteLine("Машина едет");
        //}
        public Car (string name)
            :base (name) { }

        int speed;
        public override int Speed { get; set; }

    }
    class Auto : Car
    {
        public Auto(string name) : base(name)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Легковая машина едет");
        }
    }

    //abstract class Boat : Transport { }

    class AbstractClass
    {
        public static void MainX (string[] args)
        {
            //Transport tesla = new Transport(); не можем использовать конструктор
            //для создания абстрактного класса
            Transport car = new Auto("Машина");
            Transport ship = new Ship("корабль");
            Transport aircraft = new Aircraft("самолёт");

            car.Move();
            ship.Move();
            aircraft.Move();
        }
    }
}
