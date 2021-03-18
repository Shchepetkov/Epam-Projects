using System;

namespace Epam.Task_2.Task_2_1.Task_2_1_2
{
   public class Rectangle : Figure
   {
      private Line A;
      private Line B;
      public Rectangle(int a, int b)
      {
         A = new Line(a);
         B = new Line(b);
         name = "Прямоугльник";
      }
      public int Perimetr() => 2 * (A.Side + B.Side);
      public double Square() => A.Side * B.Side;

      public override string ToString()
      {
         return $"Прямоугльник: Площадь - {Square()} --- Периметр - {Perimetr()}";
      }
   }
}