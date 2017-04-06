using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_OOP
{
    class Food
    {
        int width;
        int height;
        char sym;

        Random rand = new Random();

        public Food(int width, int height, char sym)
        {
            this.width = width;
            this.height = height;
            this.sym = sym;

        }

        public Point CreateFood()
        {
            int x = rand.Next(2, width - 2);
            int y = rand.Next(2, height - 2);
            return new Point(x, y, sym);
        }

    }
}
