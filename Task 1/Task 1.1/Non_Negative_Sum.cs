using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_1.Task_1_1
{
   public class Non_Negative_Sum
   {
      public void m()
      {
         Console.WriteLine("\t Non Negative Sum");

         int n, summa = 0;
         Console.Write("ввидите число n(размер массива): ");
         n = Int32.Parse(Console.ReadLine());
         int[] x = new int[n];
         Console.WriteLine("Ввидите элементы массива: ");
         for (int i = 0; i < n; i++)
         {
            x[i] = int.Parse(Console.ReadLine());
         }
         for (int i = 0; i < n; i++)
         {
            if (x[i] > 0)
            {
               summa += x[i];
            }
         }
         Console.WriteLine("Сумма неотрицательных элементов : " + summa);
         Console.WriteLine("Нажмите любую клавишу");
         Console.ReadKey();
      }
   }
}
