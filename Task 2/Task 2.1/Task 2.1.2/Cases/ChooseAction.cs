using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_2.Task_2_1.Task_2_1_2.Cases
{
   public class ChooseAction
   {
      public void Action(List<string> figuresName)
      {
        Console.WriteLine("Выберите тип фигуры:");
         foreach (var item in figuresName)
         {
            Console.WriteLine(item);
         }
      }
   }
}
