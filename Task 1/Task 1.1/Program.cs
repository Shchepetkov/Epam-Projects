using System;
using Epam.Task_1.Task_1_1;

namespace Epam
{
   class Program
   {
      static void Main(string[] args)
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
                  Rectangle task01 = new Rectangle();
                  task01.m();
                  break;
               case "2":
                  Console.Clear();
                  Triangle task02 = new Triangle();
                  task02.m();
                  break;
               case "3":
                  Console.Clear();
                  Another_Triangle task03 = new Another_Triangle();
                  task03.m();
                  break;
               case "4":
                  Console.Clear();
                  X_Mas_Tree task04 = new X_Mas_Tree();
                  task04.m();
                  break;
               case "5":
                  Console.Clear();
                  Sum_OF_Numbers task05 = new Sum_OF_Numbers();
                  task05.m();
                  break;
               case "6":
                  Console.Clear();
                  Font_Adjustment task06 = new Font_Adjustment(); // не красиво!!!
                  task06.m();
                  break;
               case "7":
                  Console.Clear();
                  Array_Processing task07 = new Array_Processing();
                  task07.m();
                  break;
               case "8":
                  Console.Clear();
                  No_Positive task08 = new No_Positive();
                  task08.m();
                  break;
               case "9":
                  Console.Clear();
                  Non_Negative_Sum task09 = new Non_Negative_Sum();
                  task09.m();
                  break;
               case "10":
                  Console.Clear();
                  _2D_Array task10 = new _2D_Array();
                  task10.m();
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
