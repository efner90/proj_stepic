using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Generics
{
    static class EnumerableExtansions
    {
        public static T FindMax<T>(this IEnumerable<T> en)
            where T : IComparable
        {
            bool firstTime = true;
            T max = default(T);
            foreach (var i in en)
                if (firstTime || max.CompareTo(i) <0)
                {
                    max = i;
                    firstTime = false;
                }
            return max;
        }
        
            
    }
        
    
    
    
    class Generic_Extension
    {
        public static void MainX()
        {
            Console.WriteLine(new[] { 1, 2, 4, 5, 6, 7 }.FindMax());
        }
    }
}
