using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam_Projects.Task01
{
   public class FigureOnChart
   {
   public int x { get; set; }
    public int y { get; set; }
    public int HeightG { get; set; }
    public int WidthG { get; set; }
    public int Row { get; set; }// Ряд
    public int Column { get; set; } // Колонка
    public char[,] FieldView = new char[150,150];
      
      public virtual void Draw()
      {
          for (Row = 0; Row <= HeightG / 2; Row++) {
            for (Column = 0; Column <= WidthG; Column++)
            Console.Write(FieldView[Row,Column]);
            Console.WriteLine(" ");
        }
      }
   }
}
