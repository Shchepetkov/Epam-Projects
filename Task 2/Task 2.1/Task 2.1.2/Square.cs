using System;

namespace Epam.Task_2.Task_2_1.Task_2_1_2
{
   public class Square : Figure
   {
      private Line A;
      public Square(int a)
      {
         A = new Line(a);
         name = "Квадрат";
      }
      public int Perimetr() => 4 * A.Side;
      public double Square1() => A.Side * A.Side;

      public override string ToString()
      {
         return $"Квадрат: Площадь - {Square1()} --- Периметр - {Perimetr()}";
      }
   }
}