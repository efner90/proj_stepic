using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic._9._1_Потоки__Disponsable
{
    class Ввод_вывод
    {
        static void MainX ()
        {
            File.WriteAllText("text.txt", "Some word");
            Console.WriteLine(File.ReadAllText("text.txt"));

            var textWriter = new StreamWriter("text.txt"); // открывает на запись
            textWriter.WriteLine("1 stroka");
            textWriter.WriteLine("2 stroka");
            textWriter.Flush(); //сбрасывает с буфера на диск
            textWriter.WriteLine("3 stroka");
            textWriter.Close();

            var textReader = new StreamReader("text.txt");
            while(true)
            {
                var str = textReader.ReadLine();
                if (str == null) break;
                Console.WriteLine(str);
            }
            textReader.Close();
        }
    }
}
