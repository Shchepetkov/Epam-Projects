using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_1.Task_1_1
{
   public class X_Mas_Tree
   {
      public void m(int n)
      {
         for (int i = 1; i <= n; i++)
         {
            for (int j = 0; j < i; j++)
            {
               string branch = new String('*', j);
               Console.WriteLine(branch.PadLeft(n - 1) + "*" + branch);
            }
         }
      }
   }
}
