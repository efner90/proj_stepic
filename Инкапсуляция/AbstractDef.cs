using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Инкапсуляция
{
    //абстрактный класс фигуры
    abstract class Shape
    {
        //абстрактный метод для получения периметра
        public abstract double GetPerimeter();
        //абстрактный метод для получения площади
        public abstract double GetArea();
    }
    //произволный класс прямоугольника
    class Rectngle : Shape
    {
        public float Width { get; set; }
        public float Height { get; set; }

        //переопределение получения периметра
        public override double GetPerimeter()
        {
            return Width *2 + Height *2;
        }
        //переопределение получения площади
        public override double GetArea() => Width * Height;
    }

    //произвольный класс окружности
    class Cirlce : Shape
    {
        public double Radius { get; set; }
        //переопределение периметра и площади
        public override double GetPerimeter() => Radius * 2 * Math.PI;
        public override double GetArea() => Radius * Radius * Math.PI;
    }
    
    class AbstractDef
    {
        static void Main(string[] args)
        {
            void PrintShape(Shape shape)
            {
                Console.WriteLine($"Perimetr : {shape.GetPerimeter()} \nArea: {shape.GetArea()} ");
            }
            var rectangle = new Rectngle() { Width = 20, Height = 20 };
            var circle = new Cirlce() { Radius = 150 };
            PrintShape(rectangle);
            PrintShape(circle);

        }
    }
}
