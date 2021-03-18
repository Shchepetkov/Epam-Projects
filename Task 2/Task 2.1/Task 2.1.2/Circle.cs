using System;

namespace Epam.Task_2.Task_2_1.Task_2_1_2
{
   public class Circle : Figure
   {
      public (int, int) Coordinates { get; private set; }
      public int Radius { get; private set; }
      public Circle(int x, int y, int rad)
      {
         Coordinates = (x, y);
         Radius = rad;
         name = "Окружность";
      }
      public double Circumference() => 2 * Math.PI * Radius;
   }
}