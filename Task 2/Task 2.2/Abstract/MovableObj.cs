using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using game.Enum;
using game.Struct;

namespace game.Abstract
{
   public abstract class MovableObj : GameObj
   {
      public DirectionMovement direction;
      abstract public void Move(int offset, DirectionMovement direction);
   }
}
