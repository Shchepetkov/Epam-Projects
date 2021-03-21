using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using game.Abstract;
using game.Struct;

namespace game.Canvas
{
    public class VerticalLine : GameObj
    {
         public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point{x = x, y = y, symbol = sym};
                pList.Add(p);
            }
        }
    }
}
