using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_OOP
{
    class Walls
    {
        List<Figure> fList;

        public Walls(int width, int height)
        {
            fList = new List<Figure>();

            fList.Add(new VerticalLine(0, 0, 24, '+'));
            fList.Add(new VerticalLine(78, 0, 24, '+'));
            fList.Add(new HorizontaLine(0, 0, 78, '+'));
            fList.Add(new HorizontaLine(0, 24, 78, '+'));
            

        }

        public void Draw()
        {
            foreach ( var i in fList)
            {
                i.Draw();
            }
        }

        internal bool IsHit(Figure f)
        {
            foreach (var wall in fList)
            {
                if (wall.IsHit(f))
                    return true; 
            }
            return false;
        }
    }
}
