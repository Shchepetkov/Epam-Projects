using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_2.Task_2_1.Task_2_1_2.Cases
{
   public class CaseToCase5
   {
      public void Action(ListFigures activeList)
      {
         Console.WriteLine("Введите параметры фигуры окружность: ");
         Console.WriteLine("Введите координыт центра: ");
         Console.WriteLine("A: ");
         int cA = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("B: ");
         int cB = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Введите радиус: ");
         int cR = Convert.ToInt32(Console.ReadLine());
         Circle circle = new Circle(cA, cB, cR);
         circle.CreatedOk();
         Console.WriteLine("Нажмите на любую клавишу что бы продолжить");
         Console.ReadKey();
         activeList.AddToList(circle);
      }
   }
}
