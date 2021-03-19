using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_1.Task_1_1
{
   public class Another_Triangle
   {
      public void Action()
      {
         Console.WriteLine("\t Another Triangle");
         Console.Write("Введите число ступеней: ");
         int count = Convert.ToInt32(Console.ReadLine());
         for (int i = 0; i < count; i++)
            Console.WriteLine("".PadLeft(1 + i * 2, '*').PadLeft(count + i, ' '));
         Console.WriteLine("Нажмите любую клавишу");
         Console.ReadKey();
      }
   }
}
