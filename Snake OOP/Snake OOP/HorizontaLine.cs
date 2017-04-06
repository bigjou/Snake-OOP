using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_OOP
{
    class HorizontaLine : Figure
    {
        

        //konstruktor
        public HorizontaLine(int xLeft, int _y, int xRight, char _sym)
        {
            plist = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, _y, _sym);
                plist.Add(p);
            }

        }

        

    }
}
