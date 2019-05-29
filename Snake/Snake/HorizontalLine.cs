using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int start, int end, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = start; x < end; x++)
            {
                pList.Add(new Point(x, y, sym));
            }
        }
    }
}
