using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_1.Task_1_1
{
   public class No_Positive
   {
      public void Action()
      {
         Console.WriteLine("\t No Positive");

         int[,,] array = { { { 1, 2, 3 }, { -4, 5, 6 } } };
         for (int i = 0; i < array.GetLength(0); i++)
         {
            for (int j = 0; j < array.GetLength(1); j++)
            {
               for (int k = 0; k < array.GetLength(2); k++)
               {
                  if (array[i, j, k] > 0)
                  {
                     array[i, j, k] = 0;
                     Console.WriteLine(array[i, j, k]);
                  }
                  else
                  {
                     Console.WriteLine(array[i, j, k]);
                  }
               }
            }
         }
         Console.WriteLine("Нажмите любую клавишу");
         Console.ReadKey();
      }
   }
}
