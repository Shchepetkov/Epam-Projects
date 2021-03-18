using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_2.Task_2_1.Task_2_1_2.Cases
{
   public class CaseToCase2
   {
      public void Action(ListFigures activeList)
      {
         Console.WriteLine("Введите параметры фигуры треугольник: ");
         Console.Write("Введите сторону A: ");
         int trA = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите сторону B: ");
         int trB = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите сторону C: ");
         int trC = Convert.ToInt32(Console.ReadLine());
         Triangle triangle = new Triangle(trA, trB, trC);
         triangle.CreatedOk();
         Console.WriteLine("Нажмите на любую клавишу что бы продолжить");
         Console.ReadKey();
         activeList.AddToList(triangle);
      }
   }
}
