﻿using System;
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

            Console.SetBufferSize(80,25);

            VerticalLine leftLine = new VerticalLine(0,0,24,'+');
            VerticalLine rightLine = new VerticalLine(78,0,24,'+');
            HorizontaLine topLine = new HorizontaLine(0,0,78,'+');
            HorizontaLine downLine = new HorizontaLine(0,24,78,'+');
            leftLine.Draw();
            rightLine.Draw();
            topLine.Draw();
            downLine.Draw();
            Console.ReadLine();
        }
    }
}
