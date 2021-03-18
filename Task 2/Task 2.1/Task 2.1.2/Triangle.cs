using System;

namespace Epam.Task_2.Task_2_1.Task_2_1_2
{
   public class Triangle : Figure
   {
      private Line A;
      private Line B;
      private Line C;
      public Triangle(int a, int b, int c)
      {
         A = new Line(a);
         B = new Line(b);
         C = new Line(c);
         name = "Треугольник";
      }
      public int Perimetr() => A.Side + B.Side + C.Side;
      public double Square() => Math.Sqrt(Perimetr() * (Perimetr() - A.Side) * (Perimetr() - B.Side) * (Perimetr() - C.Side));

      public override string ToString()
      {
         return $"Треугольник: Периметр - {Square()} --- Периметр - {Perimetr()}";
      }
   }
}