using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_1.Task_1_2
{
   public class Menu
   {
      public void MenuSwitch()
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
                  new Averages().Action();
                  break;
               case "2":
                  Console.Clear();
                  new Doubler().Action();
                  break;
               case "3":
                  Console.Clear();
                  new Lowercase().Action();
                  break;
               case "4":
                  Console.Clear();
                  new Validator().Action();
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
