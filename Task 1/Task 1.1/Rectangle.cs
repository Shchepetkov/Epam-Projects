using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_1.Task_1_1
{
   public class Rectangle
   {
      public void m()
      {
         int a = 0;
         int b = 0;
         bool repeat = true;
         while (repeat)
         {
            Console.WriteLine("\t Rectangle");
            do
            {
               Console.Write("A = ");
            }
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0);
            do
            {
               Console.Write("B = ");
            }
            while (!int.TryParse(Console.ReadLine(), out b) || b <= 0);
            // if (a <= 0 || b <= 0)
            // {
            //    Console.WriteLine("Ошибка");
            // //    var ki = Console.ReadKey(true);
            // //    if (ki.Key != ConsoleKey.Y)
            // //       repeat = false;
            //    continue;
            // }
            Console.WriteLine("А: {0}, В: {1}, Площадь: {2}", a, b, a * b);
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
            repeat = false;
         }
      }
   }
}
