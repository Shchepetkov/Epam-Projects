using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using game.Abstract;
using game.Enum;
using game.Struct;

namespace game.Canvas
{
   public class Player : MovableObj
   {
      public Player(Point p, char sim)
      {
         symbol = sim;
         point = p;
      }

      public override void Move(int of, DirectionMovement direction)
      {
         int x = 15;
         int y = 15;
         Console.SetCursorPosition(x, y);
         Console.Write("*");
         do
         {
            switch (Console.ReadKey().Key)
            {
               case ConsoleKey.UpArrow:                  
                     y--;                  
                  break;
               case ConsoleKey.DownArrow:                  
                     y++;            
                  break;
               case ConsoleKey.LeftArrow:
                     x--;
                  break;
               case ConsoleKey.RightArrow:
                     x++;
                  break;
               case ConsoleKey.Escape:
                     return;
               default: break;
            }
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write("*");
         } while (true);
      }

   }
}
