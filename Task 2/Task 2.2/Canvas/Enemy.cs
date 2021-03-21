using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using game.Abstract;
using game.Enum;
using game.Struct;

namespace game.Canvas
{
   public class Enemy : MovableObj
   {

      public Enemy(Point tail, int lenght, DirectionMovement _direction)
      {
         direction = _direction;
         pList = new List<Point>();
         for (int i = 0; i < lenght; i++)
         {
            Point p = tail;
            Move(i, direction);
            pList.Add(p);
         }
      }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = DirectionMovement.Left;
            else if (key == ConsoleKey.RightArrow)
                direction = DirectionMovement.Right;
            else if (key == ConsoleKey.DownArrow)
                direction = DirectionMovement.Down;
            else if (key == ConsoleKey.UpArrow)
                direction = DirectionMovement.Up;
        }
      public Enemy(Player player, EnemyType type, Point dot)
      {
         switch (type)
         {
            case EnemyType.Dragon:
               Name = EnemyType.Dragon.ToString();
               break;
            case EnemyType.Zombie:
               Name = EnemyType.Zombie.ToString();
               break;
            case EnemyType.Ghost:
               Name = EnemyType.Ghost.ToString();
               break;
            case EnemyType.Vampire:
               Name = EnemyType.Vampire.ToString();
               break;
            case EnemyType.Werewolf:
               Name = EnemyType.Werewolf.ToString();
               break;
         }
         point = dot;
      }

      internal void Move()
      {
         Point tail = pList.First();
         pList.Remove(tail);
         Point head = GetNextPoint();
         pList.Add(head);

         tail.Clear();
         head.DrawingPaint();
      }

      public Point GetNextPoint()
      {
         Point head = pList.Last();
         Point nextPoint = new Point { x = point.x, y = point.y };
         Move(1, direction);
         return nextPoint;
      }
      public override void Move(int offset, DirectionMovement direction)
      {
         int x1 = point.x;
         int y1 = point.y;
         if (direction == DirectionMovement.Right)
         {
            x1 = x1 + offset;
         }
         else if (direction == DirectionMovement.Left)
         {
            x1 = x1 - offset;
         }
         else if (direction == DirectionMovement.Up)
         {
            y1 = y1 - offset;
         }
         else if (direction == DirectionMovement.Down)
         {
            y1 = y1 + offset;
         }
         // switch (direction)
         // {
         //    case DirectionMovement.Right:
         //       MoveEnemy(1, 0, point);
         //       break;
         //    case DirectionMovement.Left:
         //       MoveEnemy(-1, 0, point);
         //       break;
         //    case DirectionMovement.Up:
         //       MoveEnemy(0, -1, point);
         //       break;
         //    case DirectionMovement.Down:
         //       MoveEnemy(0, 1, point);
         //       break;
         //    default:
         //       break;
         // }
      }
   }
}
