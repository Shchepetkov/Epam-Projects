using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_1.Task_1_2
{
   public class Doubler
   {
      public void Action()
      {
         Console.WriteLine("\t Doubler");
         Console.Write("Введите предложение: ");
         string strInput = Console.ReadLine();
         Console.Write("Введите буквы которые хотите удвоить: ");
         string addLetter = Console.ReadLine();
         StringBuilder StringBuilder = new StringBuilder();

         foreach (char symbol in strInput)
         {
            if (addLetter.Contains(symbol))
            {
               StringBuilder.Append(symbol);
               StringBuilder.Append(symbol);
            }
            else
               StringBuilder.Append(symbol);
         }
         Console.WriteLine("Результат: " + StringBuilder.ToString());
         Console.WriteLine("Нажмите любую клавишу");
         Console.ReadKey();
      }
   }
}
