using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_1.Task_1_1
{
   public class Array_Processing
   {
      //метод для обмена элементов массива
      static void Swap(ref int x, ref int y)
      {
         var t = x;
         x = y;
         y = t;
      }

      //метод возвращающий индекс опорного элемента
      static int Partition(int[] array, int minIndex, int maxIndex)
      {
         var pivot = minIndex - 1;
         for (var i = minIndex; i < maxIndex; i++)
         {
            if (array[i] < array[maxIndex])
            {
               pivot++;
               Swap(ref array[pivot], ref array[i]);
            }
         }

         pivot++;
         Swap(ref array[pivot], ref array[maxIndex]);
         return pivot;
      }

      //быстрая сортировка
      static int[] QuickSort(int[] array, int minIndex, int maxIndex)
      {
         if (minIndex >= maxIndex)
         {
            return array;
         }

         var pivotIndex = Partition(array, minIndex, maxIndex);
         QuickSort(array, minIndex, pivotIndex - 1);
         QuickSort(array, pivotIndex + 1, maxIndex);

         return array;
      }

      static int[] QuickSort(int[] array)
      {
         return QuickSort(array, 0, array.Length - 1);
      }
      public void m()
      {
         Console.WriteLine("\t Array Processing");
         Random rnd = new Random();
         int syze = rnd.Next(5, 20);
         int[] ar = new int[syze];

         for (int i = 0; i < ar.Length; i++)
         {
            ar[i] = rnd.Next(-100, 100);
         }

         Console.WriteLine("Генерируем случайный массив");
         Console.WriteLine("Длина массива: {0}", ar.Length);
         Console.WriteLine("________________________");
         Console.Write("Массив до сортировки: \t");
         for (int i = 0; i < ar.Length; i++)
         {
            Console.Write(ar[i] + " ");
         }
         Console.WriteLine();

         Console.WriteLine("Массив после сортировки: {0} ", string.Join(", ", QuickSort(ar)));
         int max = ar[0];
         int min = ar[0];

         for (int i = 0; i < ar.Length; i++)
         {
            if (max < ar[i])
            {
               max = ar[i];
            }
            if (min > ar[i])
            {
               max = ar[i];
            }
         }
         Console.WriteLine("Максимальный элемент массива: " + max + " " + "Минимальный элемент массива: " + min);
         Console.WriteLine("Нажмите любую клавишу");
         Console.ReadKey();
      }
   }
}