using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_2.Task_2_1.Task_2_1_2.Cases
{
   public class CaseToCase4
   {
      public void Action(ListFigures activeList)
      {
         Console.WriteLine("Введите параметры фигуры прямоугльник: ");
         Console.Write("Введите сторону A: ");
         int reA = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите сторону B: ");
         int reB = Convert.ToInt32(Console.ReadLine());
         Rectangle rectangle = new Rectangle(reA, reB);
         rectangle.CreatedOk();
         Console.WriteLine("Нажмите на любую клавишу что бы продолжить");
         Console.ReadKey();
         activeList.AddToList(rectangle);
      }
   }
}
