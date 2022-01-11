using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Generics
{
    
    
    class Generic_Method
    {
        static T FindMax<T>(IEnumerable<T> en)
            where T: IComparable

        {
            bool firstTime = true;
            T max = default(T);
            foreach (var e in en)
                if (firstTime || max.CompareTo(e) < 0)
                {
                    max = e;
                    firstTime = false;
                }
            return max;
        }

        public static void MainX()
        {
            Console.WriteLine(FindMax(new[] { 3, 4, 2, 5, 7 }));
        }
    }
}
