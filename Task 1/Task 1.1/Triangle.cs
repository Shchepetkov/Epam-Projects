using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_1.Task_1_1
{
   public class Triangle
   {
      public void m()
      {
         Console.WriteLine("\t Triangle");
         Console.Write("Введите число: ");
         int count = Convert.ToInt32(Console.ReadLine());
         for (int i = 0; i <= count; i++)
         {
            for (int j = 0; j <= i; j++)
            {
               Console.Write("*");
            }
            Console.Write("\n");
         }
         Console.WriteLine("Нажмите любую клавишу");
         Console.ReadKey();
      }
   }
}
