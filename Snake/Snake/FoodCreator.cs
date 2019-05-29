using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapW;
        int mapH;
        char sym;

        Random rnd = new Random();

        public FoodCreator(int w, int h, char _sym)
        {
            mapW = w;
            mapH = h;
            sym = _sym;
        }

        public Point CreateFood()
        {
            int x = rnd.Next(2, mapW - 2);
            int y = rnd.Next(2, mapH - 2);
            return new Point(x, y, sym);
        }
    }
}
