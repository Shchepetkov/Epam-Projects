using System;
using System.Collections.Generic;
using System.Linq;
using Epam.Task_2.Task_2_1.Task_2_1_2.Cases;

namespace Epam.Task_2.Task_2_1.Task_2_1_2
{
   class Program
   {
      static void Main(string[] args)
      {

         while (true)
         {
            Console.WriteLine("Выберите действие:" + Environment.NewLine + "1.Добавить фигуру" + Environment.NewLine
                            + "2.Вывести фигуры" + Environment.NewLine + "3.Очистить поле" + Environment.NewLine
                            + "4.Выход" + Environment.NewLine);
            new Menu().Action();
         }
      }
   }
}