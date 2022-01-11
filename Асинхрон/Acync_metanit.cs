using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace proj_stepic.Асинхрон
{
    class Acync_metanit
    {
        static void Factorial(int n)
        {
            int result = 1;
            for(var i = 1;i <=n;i++)
            {
                result *= i;
            }
            Thread.Sleep(5000);
            Console.WriteLine($"Факториал равен{result}");
        }
        //определение асинхронного метода
        static async void FactorialAcync(int n)
        {
            Console.WriteLine("Начало метода FactorialAcync"); //выполняется синхронно
            await Task.Run(() => Factorial(n)); //выполняется асинхронно
            Console.WriteLine("Конец метода FactorialAcync");
        }

        static async void ReadWriteAsync()
        {
            string s = "Hello! One step at time";

            //hello.txt файл, в который будет записываться и считываться
            using (StreamWriter writer = new StreamWriter("hello.txt", false))
            {
                await writer.WriteLineAsync(s); //асинхронная запись в файл
            }

            using (StreamReader reader = new StreamReader("hello.txt"))
            {
                string result = await reader.ReadToEndAsync(); //асинхронное чтение их файла
                Console.WriteLine(result);
            }
        }

        static void Main()
        {
            //FactorialAcync(); //вызов асинхронного метода
            FactorialAcync(5);
            FactorialAcync(6);
            Console.WriteLine("Некоторая работа");

            //Console.WriteLine("Введите число: ");
            //int n = Int32.Parse(Console.ReadLine());
            //Console.WriteLine($"Квадрат числа равен {n*n}");

            Console.Read();

            ReadWriteAsync();

            Console.WriteLine("Some work");
            Console.Read();
        }
    }
}
