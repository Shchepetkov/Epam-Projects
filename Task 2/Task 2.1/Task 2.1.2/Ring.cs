using System;

namespace Epam.Task_2.Task_2_1.Task_2_1_2
{
    public class Ring : Figure
    {
        private Round innerRound;
        private Round outRound;
        public Ring(int x, int y, int innerRad, int outRad)
        {
            if (outRad > innerRad)
            {
                innerRound = new Round(x, y, innerRad);
                outRound = new Round(x, y, outRad);
                name = "Кольцо";
            }
            else throw new Exception("Внешний радиус не может быть меньше внутреннего");
        }
        public double Circumference() => 2 * Math.PI * (innerRound.Radius + outRound.Radius);
        public double Square() => outRound.Square() - innerRound.Square();

      public override string ToString()
      {
         return $"Кольцо: Площадь - {Square()} --- Длина окружности - {Circumference()}";
      }

    }
}