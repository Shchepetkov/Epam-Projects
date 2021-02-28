using System;
using Epam.Task_1.Task_1_2;

namespace Epam
{
   class Program
   {
      static void Main(string[] args)
      {
         do
         {
            Console.WriteLine("\t МЕНЮ");
            Console.WriteLine("1.  Averages");
            Console.WriteLine("2.  Doubler");
            Console.WriteLine("3.  Lowercase");
            Console.WriteLine("4.  Validator");
            Console.Write("Введите номер задания от 1 до 4 если хотите выйти нажмите 0: ");
            string i = Console.ReadLine();
            switch (i)
            {
               case "1":
                  Console.Clear();
                  Averages task01 = new Averages();
                  task01.m();
                  break;
               case "2":
                  Console.Clear();
                  Doubler task02 = new Doubler();
                  task02.m();
                  break;
               case "3":
                  Console.Clear();
                  Lowercase task03 = new Lowercase();
                  task03.m();
                  break;
               case "4":
                  Console.Clear();
                  Validator task04 = new Validator();
                  task04.m();
                  break;
               case "0":
                  Console.Clear();
                  Console.WriteLine("выход");
                  return;

               default:
                  Console.Clear();
                  Console.WriteLine("Ошибка");
                  break;
            }

         } while (true);
      }
   }
}
