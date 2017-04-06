using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point(1,3,'*');
            //Point p2 = new Point(2, 4, '*');
            //Point p3 = new Point(5, 2, '*');
            //Point p4 = new Point(6, 8, '%');

            //List<char> charList = new List<char>();
            //charList.Add('*');
            //charList.Add('%');
            //charList.Add('$');
            //charList.Add('#');

            //List<Point> plist = new List<Point>();
            //plist.Add(p1);
            //plist.Add(p2);
            //plist.Add(p3);
            //plist.Add(p4);

            //foreach (Point p in plist)
            //{
            //    p.Draw();
            //}

            HorizontaLine hLine = new HorizontaLine(15,15,20,'+');
            hLine.Draw();

            VerticalLine vLine = new VerticalLine(5,6,13,'-');
            vLine.Draw();

            Console.ReadLine();
        }
    }
}
