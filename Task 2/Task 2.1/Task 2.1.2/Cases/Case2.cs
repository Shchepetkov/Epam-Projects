using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_2.Task_2_1.Task_2_1_2.Cases
{
   public class Case2
   {
      public void Action(ListFigures activeList)
      {
         if (activeList.GetList().Count() == 0)
         {
            Console.WriteLine("В наличии фигур нет");
         }
         else
         {
            Console.WriteLine("В наличии фигуры:");
            foreach (var item in activeList.GetList())
            {
               Console.WriteLine(item);
            }
         }
      }
   }
}
