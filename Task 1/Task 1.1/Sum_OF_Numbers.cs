using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_1.Task_1_1
{
   public class Sum_OF_Numbers
   {
      public void m()
      {
         int sum = 0;
         for (int i = 0; i < 1000; i++)
         {
            if (i % 3 == 0 || i % 5 == 0)
            {
               sum += i;
            }
         }
         System.Console.WriteLine(sum);
      }
   }
}
