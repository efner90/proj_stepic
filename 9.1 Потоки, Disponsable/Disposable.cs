using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic._9._1_Потоки__Disponsable
{
    class DisposableClass : IDisposable
    {
        string name;

        public DisposableClass(string name)
        {
            this.name = name;
        }

        private bool isDisposed = false;

        ~DisposableClass()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // финализатор не будет вызываться
        }

        protected virtual void Dispose (bool fromDisposeMethod)
        {
            if (!isDisposed)
            {
                if (fromDisposeMethod)
                {
                    Console.WriteLine("Очистка неуправляемых ресурсов в {0}", name);
                }
                Console.WriteLine("Очистка неуправляемых ресурсов в {0}", name);
                isDisposed = true;
                // base.Dispose(isDisposing); //еслиунаследован от Диспосабл класса
            }
        }
    }

    class Disposable
    {
        public static void Main1()
        {
            var disposble = new DisposableClass("DisposedManually");
            disposble.Dispose();

            using (disposble= new DisposableClass("DispodedWithUsing"))
            {
                Console.WriteLine("Using inside");
            }

            using (disposble = new DisposableClass("DisposedWithExeption"))
            {
                Console.WriteLine("Using inside");
                throw new Exception();
            }
        }

        public static void MainX()
        {
            Main1();
            GC.Collect();
        }
    }
}
