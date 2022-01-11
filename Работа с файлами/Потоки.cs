using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Работа_с_файлами
{
    class Потоки
    {
        public static void MainX()
        {
            using (var textWriter = new StreamWriter("text"))
            {
                textWriter.WriteLine("Строка 1");
                textWriter.WriteLine("Строка 2");
                textWriter.Flush();
                textWriter.WriteLine("Строка 3");
            }

            using (var textReader = new StreamReader("text"))
                while (true)
                {
                    var str = textReader.ReadLine();
                    if (str == null) break;
                    Console.WriteLine(str);
                }


            using (var binWriter = new BinaryWriter(File.Open("bin", FileMode.Create, FileAccess.Write)))
            {
                for (int i = 1; i <= 1024; i *= 2)
                    binWriter.Write(i);
            }

            int intLength = sizeof(int);
            var bytes = File.ReadAllBytes("bin");
            for (int i = 0; i < bytes.Length; i++)
            {
                if (i % intLength == 0) Console.WriteLine();
                Console.Write("{0:X2} ", bytes[i]);
            }
            Console.WriteLine();
        }
    }
}
