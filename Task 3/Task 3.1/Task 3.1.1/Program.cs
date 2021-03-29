using System;
using System.Collections.Generic;
using System.Linq;

namespace Epam
{
   class Program
   {
      static void Main()
      {
         Console.Write("Введите N: ");
         int Round = 1;
         int N = Convert.ToInt32(Console.ReadLine());

         var List = new LinkedList<int>(Enumerable.Range(1, N));
         Console.WriteLine("Сгенерирован круг людей. Начинаем вычеркивать каждого второго.");
         // Console.WriteLine(string.Join(", ", list)); // - вывод элементов листа от 1 до n
         var currentItem = List.First;
         while (List.Count != 1)
         {
            List.Remove(currentItem.Next ?? List.First);
            currentItem = currentItem.Next ?? List.First;
            Console.WriteLine($"Раунд {Round}. Вычеркнут человек. Людей осталось: {List.Count}.");
            Round++;
         }
         Console.WriteLine(List.First.Value);
      }
   }
}