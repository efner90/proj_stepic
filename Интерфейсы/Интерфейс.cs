using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_stepic.Интерфейсы
{
    public interface IFigure
    {
        Point Location { get; set; }
        bool Contains(Point p);
        double Area { get; }
    }

    public static class IFigureExtensions
    {
        public static bool Contains(this IFigure obj, Point[] points)
        {
            foreach (var p in points)
                if (obj.Contains(p)) return true;
            return false;
        }
    }

    /*class Square : IFigure
    {
        public Point Location { get; set; }
        public int Size { get; set; }
        public bool Contains (Point p)
        {
            return
                    Math.Abs(p.X - Location.X) < Size / 2 &&
                    Math.Abs(p.Y - Location.Y) < Size / 2;

        }
    }*/
    
    class Интерфейс
    {
    }
}
