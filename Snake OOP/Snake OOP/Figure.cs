using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_OOP
{
    class Figure
    {
         protected List<Point> plist;


         public void Draw()
         {
             foreach (Point p in plist)
             {
                 p.Draw();
             }
         }


         internal bool IsHit(Figure f)
         {
             foreach (var p in plist)
             {
                 if (f.IsHit(p))
                     return true;
             }
             return false;
         }

         private bool IsHit(Point point)
         {
             foreach (var p in plist)
             {
                 if (p.isHit(point))
                 {
                     return true;
                 }
             }
             return false;
         }
    }
}
