using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using game.Abstract;
using game.Enum;
using game.Struct;

namespace game.Canvas
{
   public class Bonus : UnmovableObj
   {
      public Bonus(BonusType type, Point p)
      {
         switch (type)
         {
            case BonusType.Jewel:
               // Name = BonusType.Jewel.ToString();
               break;
            case BonusType.Coin:
               // Name = BonusType.Coin.ToString();
               break;
            case BonusType.ExtraLife:
               // Name = BonusType.ExtraLife.ToString();
               break;
            case BonusType.Cartridge:
               // Name = BonusType.Cartridge.ToString();
               break;
         }
         // P = p;
      }
   }
}
