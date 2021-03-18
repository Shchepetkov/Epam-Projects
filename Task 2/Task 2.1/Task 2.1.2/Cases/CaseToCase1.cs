using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_2.Task_2_1.Task_2_1_2.Cases
{
   public class CaseToCase1
   {
      public void Action(ListFigures activeList)
      {
         Console.WriteLine("Введите параметры линии:");
         Console.Write("Введите длину: ");
         int lineA = Convert.ToInt32(Console.ReadLine());
         Line line = new Line(lineA);
         line.CreatedOk();
         Console.WriteLine("Нажмите на любую клавишу что бы продолжить");
         Console.ReadKey();
         activeList.AddToList(line);
      }
   }
}
