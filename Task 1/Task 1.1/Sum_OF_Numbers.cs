using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_1.Task_1_1
{
   public class Sum_OF_Numbers
   {
      public void Action()
      {
         Console.WriteLine("\t Sum OF Numbers");
         int sum = 0;
         for (int i = 0; i < 1000; i++)
         {
            if (i % 3 == 0 || i % 5 == 0)
            {
               sum += i;
            }
         }
         Console.WriteLine(sum);
         Console.WriteLine("Нажмите любую клавишу");
         Console.ReadKey();
      }
   }
}
