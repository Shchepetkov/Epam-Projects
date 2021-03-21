using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using game.Enum;
using game.Struct;
using game.Abstract;

namespace game.Canvas
{
   public class GameField
   {
      public int Width { get; set; }

      public int Height { get; set; }

      Player player = new Player(new Point { x = 1, y = 1 }, '*');
      public void Start()
      {
         Walls walls = new Walls(80, 25);
         walls.Draw();
         Point p = new Point { x = 1, y = 1, symbol = '*' };
         Enemy snake = new Enemy(p, 4, DirectionMovement.Right);
         while (true)
         {
            snake.Move();


            if (Console.KeyAvailable)
            {
               ConsoleKeyInfo key = Console.ReadKey();
               snake.HandleKey(key.Key);
            }
         }
         //  player.Move(DirectionMovement.Up);
      }
      public GameField()
      {
         Start();
      }
   }
}
