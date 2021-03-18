using System;

namespace Epam.Task_2.Task_2_1.Task_2_1_2
{
   public class Round : Circle
   {
      public Round(int x, int y, int radius) : base(x, y, radius)
      {
         name = "Круг";
      }
      public double Square() => Math.PI * Radius * Radius;

      public override string ToString()
      {
         return $"Круг: Периметр - {Square()}";
      }
   }
}