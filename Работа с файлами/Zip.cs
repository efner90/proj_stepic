using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Работа_с_файлами
{
    class Zip
    {
        public static void MainX()
        {
            var Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. ";
            for (int i = 0; i < 10; i++) Text += Text;

            using (var dstStream = new MemoryStream())
            {
                using (var writer = new StreamWriter(new GZipStream(dstStream, CompressionMode.Compress)))
                    writer.WriteLine(Text);

                Console.WriteLine("Начальная длина - {0}", Text.Length);
                var buffer = dstStream.GetBuffer();
                Console.WriteLine("Длина после сжатия - {0}", buffer.Length);


                for (int i = 0; i < 100; i++)
                    Console.Write((char)buffer[i]);

                using (var reader = new StreamReader(new GZipStream(new MemoryStream(buffer), CompressionMode.Decompress)))
                {
                    var line = reader.ReadLine();
                    Console.WriteLine(line == Text ? "OK" : "FAIL");
                }
            }
        }
    }
}
