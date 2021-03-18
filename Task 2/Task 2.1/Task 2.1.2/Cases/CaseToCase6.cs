using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_2.Task_2_1.Task_2_1_2.Cases
{
   public class CaseToCase6
   {
      public void Action(ListFigures activeList)
      {
         Console.WriteLine("Введите параметры фигуры круг: ");
         Console.WriteLine("Введите координыт центра: ");
         Console.WriteLine("A: ");
         int rA = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("B: ");
         int rB = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Введите радиус: ");
         int rR = Convert.ToInt32(Console.ReadLine());
         Round round = new Round(rA, rB, rR);
         round.CreatedOk();
         Console.WriteLine("Нажмите на любую клавишу что бы продолжить");
         Console.ReadKey();
         activeList.AddToList(round);
      }
   }
}
