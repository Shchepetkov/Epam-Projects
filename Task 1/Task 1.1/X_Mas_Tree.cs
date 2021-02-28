using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_1.Task_1_1
{
   public class X_Mas_Tree
   {
      public void m()
      {
         Console.WriteLine("\t X-Mas Tree");
         Console.Write("Введите число треугольников: ");
         int count = Convert.ToInt32(Console.ReadLine());
         for (int i = 1; i <= count; i++)
         {
            for (int j = 0; j < i; j++)
            {
               string branch = new String('*', j);
               Console.WriteLine(branch.PadLeft(count - 1) + "*" + branch);
            }
         }
         Console.WriteLine("Нажмите любую клавишу");
         Console.ReadKey();
      }
   }
}
