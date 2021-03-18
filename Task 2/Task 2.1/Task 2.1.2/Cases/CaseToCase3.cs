using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_2.Task_2_1.Task_2_1_2.Cases
{
   public class CaseToCase3
   {
      public void Action(ListFigures activeList)
      {
         Console.WriteLine("Введите параметры фигуры квадрат: ");
         Console.Write("Введите сторону: ");
         int sqA = Convert.ToInt32(Console.ReadLine());
         Square square = new Square(sqA);
         square.CreatedOk();
         Console.WriteLine("Нажмите на любую клавишу что бы продолжить");
         Console.ReadKey();
         activeList.AddToList(square);
      }
   }
}
