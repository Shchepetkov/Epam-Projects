using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace game.Struct
{
   public struct Point
   {
      public int x { get; set; }
      public int y { get; set; }

      public char symbol { get; set; }

      public void Clear()
      {
         symbol = ' ';
         DrawingPaint();
      }
      public void DrawingPaint()
      {
         if (x <= 78 && y == 0 || x <= 78 && y == 24)
         {
            if (y == 0)
            {
               Console.SetCursorPosition(x, y);
               Console.WriteLine('+');
               y = y + 1;
            }
            else if (y == 24)
            {
               Console.SetCursorPosition(x, y);
               Console.WriteLine('+');
               y = y - 1;
            }
         }
         else if (y <= 24 && x == 0 || y <= 24 && x == 78)
         {
            if (x == 0)
            {
               Console.SetCursorPosition(x, y);
               Console.WriteLine('+');
               x = x + 1;
            }
            else if (x == 78)
            {
               Console.SetCursorPosition(x, y);
               Console.WriteLine('+');
               x = x - 1;
            }
         }
         Console.SetCursorPosition(x, y);
         if (symbol != '+')
            Console.WriteLine(symbol);
      }
   }
}
