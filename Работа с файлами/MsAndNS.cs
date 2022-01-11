using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;

namespace proj_stepic.Работа_с_файлами
{
    class MsAndNS
    {
        static void MemoryStreamMain(string[] args)
        {

            using (var memoryStream = new MemoryStream())
            using (var binWriter = new BinaryWriter(memoryStream))
            {

                for (int i = 1; i <= 1024; i *= 2)
                    binWriter.Write(i);
                binWriter.Flush();

                int intLength = sizeof(int);
                var bytes = memoryStream.GetBuffer();
                for (int i = 0; i < memoryStream.Position; i++)
                {
                    if (i % intLength == 0) Console.WriteLine();
                    Console.Write("{0:X2} ", bytes[i]);
                }
                Console.WriteLine();
            }
        }

        static void Server()
        {
            var listener = new TcpListener(13000);
            listener.Start();
            using (var client = listener.AcceptTcpClient())
            {
                var stream = client.GetStream();
                var textStream = new StreamReader(stream);
                while (true)
                {
                    var line = textStream.ReadLine();
                    if (line == "") break;
                    Console.WriteLine(line);
                }
            }
            listener.Stop();
        }

        static void MainNetworkStream(string[] args)
        {
            new Action(Server).BeginInvoke(null, null);
            Thread.Sleep(1000);

            using (var client = new TcpClient())
            {
                client.Connect("127.0.0.1", 13000);
                var stream = client.GetStream();
                var textStream = new StreamWriter(stream);
                textStream.WriteLine("Test line 1");
                textStream.Flush();
                textStream.WriteLine("Test line 2");
                textStream.Flush();
                textStream.WriteLine();
                textStream.Flush();
            }

            Thread.Sleep(1000);
        }
    }
}
