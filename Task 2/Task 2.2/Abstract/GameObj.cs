using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using game.Struct;

namespace game.Abstract
{
   public abstract class GameObj
   {
      protected List<Point> pList;
      public virtual Point point { get; set; }
      public virtual char symbol { get; protected set; }
      public virtual string Name { get; protected set; }

      public void Draw()
        {
            foreach (Point p in pList)
            {
                p.DrawingPaint();
            }

        }
   }
}
