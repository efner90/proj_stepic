using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Работа_с_файлами
{
    

    class ReadLineses
    {
        static IEnumerable<string> ReadLines(string filename)
        {
            using (var stream = new StreamReader(filename))
                while (true)
                {
                    var str = stream.ReadLine();
                    if (str == null)
                    {
                        stream.Close();
                        yield break;
                    }
                    yield return str;
                }
        }

        static void MainX(string[] args)
        {
            File.WriteAllLines("text", new[] { "A", "B", "C" });

            foreach (var e in ReadLines("text"))
                Console.WriteLine(e);

            foreach (var e in File.ReadLines("text"))
                Console.WriteLine(e);
        }
    }
}
