using System;

namespace Epam_Projects.Task01
{
   class Circle : FigureOnChart
   {
      int radius, angle; // Угол

      public Circle(char symbol, int HeightG, int WidthG, int radius, bool showGraphFunctions)
      {
         this.HeightG = HeightG; // Высота графика
         this.WidthG = WidthG; // Ширина графика
         this.radius = radius; // Радиус

         for (Row = 0; Row <= (int)(HeightG / 2.5); Row++)
         {
            for (Column = 0; Column <= WidthG; Column++)
            {
               FieldView[Row, Column] = ' ';
            }
         }

         if (showGraphFunctions)
         {
            for (Column = 0; Column <= WidthG; Column++)
            {
               Row = (int)(HeightG / 2.5) / 2;
               FieldView[Row, Column] = '-'; // линия Х
            }

            for (Row = 0; Row <= (int)(HeightG / 2.5); Row++)
            {
               Column = WidthG / 2;
               FieldView[Row, Column] = '|'; // линия У
            }
         }

         for (angle = (int)(360 * Math.PI / 180); angle <= 360; angle += 1)
         {
            x = (int)(radius * Math.Cos(angle));
            y = (int)(radius * Math.Sin(angle));

            Row = (((int)(HeightG / 2.5) / 2) - (y / 2));
            Column = WidthG / 2 + x;
            FieldView[Row, Column] = symbol;
         }
      }
   }
}