using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic._9._1_Потоки__Disponsable
{
    class Исключения
    {
        
        const string Filename = "text.txt";

        static string CreateReport()
        {
            throw new Exception();
        }

        static void CheckFile()
        {
            Console.WriteLine(File.ReadAllText(Filename));
        }

        static void MakeReport1()
        {
            var writer = new StreamWriter(Filename);
            for (var i = 0; i < 10; i++)
            {
                writer.WriteLine($"{i} Report header's");
            }
            writer.WriteLine(CreateReport());
            writer.Close();
        }

        static void MakeReport2()
        {
            try
            {
                var writer = new StreamWriter(Filename);
                for (var i = 0; i < 10; i++)
                {
                    writer.WriteLine($"{i} Report header's");
                }
                writer.WriteLine(CreateReport());
                writer.Close();
            }
            catch
            {
                Console.WriteLine("Error making report");
            }
        }

        static void MakeReport3()
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(Filename);
                for (var i = 0; i < 10; i++)
                {
                    writer.WriteLine($"{i} Report header's");
                }
                writer.WriteLine(CreateReport());
                //writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error making report: "+ e.Message);
            }
            finally
            {
                writer.Close();
            }
        }

        static void MakeReport4()
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(Filename);
                for (var i = 0; i < 10; i++)
                {
                    writer.WriteLine($"{i} Report header's");
                }
                writer.WriteLine(CreateReport());
                //writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error making report: " + e.Message);
            }
            finally
            {
                if (writer !=null)
                    writer.Close();
            }
        }

        static void MakeReport5()
        {
            StreamWriter writer = null;
            writer = new StreamWriter(Filename);
            try
            {
                for (var i = 0; i < 10; i++)
                {
                    writer.WriteLine($"{i} Report header's");
                }
                writer.WriteLine(CreateReport());
            }
            finally
            {
                writer.Close();
            }
        }

        static void MakeReport6() //как и 5 репортмейкер
        {
            using (var writer = new StreamWriter(Filename))
            {
                for (var i = 0; i < 10; i++)
                {
                    writer.WriteLine($"{i} Report header's");
                }
                writer.WriteLine(CreateReport());
            }
        }

        static void TryMakeReport(Action reportmaker)
        {
            try
            {
                reportmaker();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error report : " + e.Message);
            }
        }
        static void MainX()
        {
            //MakeReport1();
            //MakeReport2();
            //MakeReport3();
            //MakeReport4();
            //MakeReport5();
            //TryMakeReport(MakeReport5);
            TryMakeReport(MakeReport6);
        }
        



        }
}
