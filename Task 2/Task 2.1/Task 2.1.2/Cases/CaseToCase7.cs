using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_2.Task_2_1.Task_2_1_2.Cases
{
   public class CaseToCase7
   {
      public void Action(ListFigures activeList)
      {
         Console.WriteLine("Введите параметры фигуры кольцо: ");
         Console.WriteLine("Введите координыт центра: ");
         Console.Write("A: ");
         int ringA = Convert.ToInt32(Console.ReadLine());
         Console.Write("B: ");
         int ringB = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите внутренний радиус: ");
         int ringInR = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите внешний радиус: ");
         int ringOutR = Convert.ToInt32(Console.ReadLine());
         Ring ring = new Ring(ringA, ringB, ringInR, ringOutR);
         ring.CreatedOk();
         Console.WriteLine("Нажмите на любую клавишу что бы продолжить");
         Console.ReadKey();
         activeList.AddToList(ring);
      }
   }
}
