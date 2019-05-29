using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int start, int end, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = start; y < end; y++)
            {
                pList.Add(new Point(x, y, sym));
            }
        }
    }
}
