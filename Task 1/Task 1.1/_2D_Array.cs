using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_1.Task_1_1
{
   public class _2D_Array
   {
      public void m()
      {
         Console.Write("Введите размерность массива: ");
         int size = int.Parse(Console.ReadLine());
         int[,] array = new int[size, size];
         Random rnd = new Random();

         for (int i = 0; i < array.GetLength(0); i++)
         {
            for (int j = 0; j < array.GetLength(1); j++)
            {
               array[i, j] = rnd.Next(-10, 10);
               Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
         }

         int Sum = 0;
         for (int i = 0; i < array.GetLength(0); i++)
         {
            for (int j = 0; j < array.GetLength(1); j++)
            {
               if (i == j)
                  Sum += array[i, j];
            }
         }
         Console.WriteLine("Сумма : " + Sum);
      }
   }
}
