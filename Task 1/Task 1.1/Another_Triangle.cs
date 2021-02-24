using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_1.Task_1_1
{
   public class Another_Triangle
   {
      public void m(int n)
      {
         for (int i = 0; i < n; i++)
            Console.WriteLine("".PadLeft(1 + i * 2, '*').PadLeft(n + i, ' '));
      }
   }
}
