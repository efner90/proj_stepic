using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic
{
    public class TestClass
    {
        private int oddnumber;
        public int GetOddNumber() { return oddnumber; } //никрасива
        public void SetOddNumber(int value)
        {
            if (value % 2 == 0)
            {
                throw new ArgumentException();
            }
            oddnumber = value;
        }
        //всё что выше некрасивое описание свойств

        private int evenNumber;
        public int EvenNumber
        {
            get
            {
                Console.WriteLine("Вызван геттер");
                return evenNumber;
            }
            set
            {
                Console.WriteLine("Вызван сеттер");
                if (value % 2 != 0)
                {
                    Console.WriteLine("Исключение выброшено");
                    throw new ArgumentException();
                }
                evenNumber = value;
            }
        }
    }

    class SecondTest
    {
        int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        //нежелательная цапись полей и его свойств

        public int AnotherNumber { get; set; }

        public int GetOnlyNumber { get; private set; }
        public readonly int ReadOnlyNumber;

        void Method()
        {
            GetOnlyNumber = 1;
            //нельзя изменять значение редонли полей
            //ReadOnlyNumber = 1;
        }

        public int Product
        {
            get { return Number * AnotherNumber; } //функциональные свойства
        }
    }

    class AB
    {
        public int Number
        {
            set { Console.WriteLine("Hello world"); }
        }
        
        
    } 
            


    class КонцепцияСвойств
    {
        public static void MainX()
        {
            var obj = new TestClass();
            obj.SetOddNumber(1);
            obj.SetOddNumber(obj.GetOddNumber() + 2);


            Console.WriteLine("Присвоение свойству значения");
            obj.EvenNumber = 2;

            Console.WriteLine("\n\nПолучение значения свойства");
            var a = obj.EvenNumber;

            Console.WriteLine("\n\nУвеличение значения свойства");
            obj.EvenNumber += 2;

            Console.WriteLine("\n\nНекорректное присвоение значения");
            try
            {
                obj.EvenNumber = 3;
            }
            catch
            {
                Console.WriteLine("Исключение обработано");
            }

            var ab = new AB();
            ab.Number = 1;
        }
    }
}
