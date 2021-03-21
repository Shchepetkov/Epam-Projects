using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using game.Abstract;
using game.Enum;
using game.Struct;

namespace game.Canvas
{
   public class Barier : UnmovableObj
   {
      public Barier(BarrierType type, Point p)
      {
         switch (type)
         {
            case BarrierType.Stone:
               // Name = BarrierType.Stone.ToString();
               break;
            case BarrierType.Ravine:
               // Name = BarrierType.Ravine.ToString();
               break;
            case BarrierType.Tree:
               // Name = BarrierType.Tree.ToString();
               break;
            case BarrierType.Fence:
               // Name = BarrierType.Fence.ToString();
               break;
         }
         // P = p;
      }
   }
}
