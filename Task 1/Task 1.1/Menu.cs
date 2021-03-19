using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Epam.Task_1.Task_1_1;

namespace Epam.Task_1.Task_1_1
{
   public class Menu
   {
      public void MenuSwitch()
      {
         do
         {
            Console.WriteLine("\t МЕНЮ");
            Console.WriteLine("1.  Rectangle");
            Console.WriteLine("2.  Triangle");
            Console.WriteLine("3.  Another Triangle");
            Console.WriteLine("4.  X-Mas Tree");
            Console.WriteLine("5.  Sum OF Numbers");
            Console.WriteLine("6.  Font Adjustment");
            Console.WriteLine("7.  Array Processing");
            Console.WriteLine("8.  No Positive");
            Console.WriteLine("9.  Non Negative Sum");
            Console.WriteLine("10. 2D Array");
            Console.Write("Введите номер задания от 1 до 10 если хотите выйти нажмите 0: ");
            string i = Console.ReadLine();
            switch (i)
            {
               case "1":
                  Console.Clear();
                  new Rectangle().Action();
                  break;
               case "2":
                  Console.Clear();
                  new Triangle().Action();
                  break;
               case "3":
                  Console.Clear();
                  new Another_Triangle().Action();
                  break;
               case "4":
                  Console.Clear();
                  new X_Mas_Tree().Action();
                  break;
               case "5":
                  Console.Clear();
                  new Sum_OF_Numbers().Action();
                  break;
               case "6":
                  Console.Clear();
                  new Font_Adjustment().Action();
                  break;
               case "7":
                  Console.Clear();
                  new Array_Processing().Action();
                  break;
               case "8":
                  Console.Clear();
                  new No_Positive().Action();
                  break;
               case "9":
                  Console.Clear();
                  new Non_Negative_Sum().Action();
                  break;
               case "10":
                  Console.Clear();
                  new _2D_Array().Action();
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
