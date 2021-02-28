using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_1.Task_1_2
{
   public class Lowercase
   {
      public void m()
      {
         Console.WriteLine("\t Lowercase");
         Console.Write("Введите предложение: ");
         string Input = Console.ReadLine();

         string[] splitedString = Input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
         int count = 0;

         for (int i = 0; i < splitedString.Length; i++)
         {
            System.Console.WriteLine(splitedString[i]);
            if (splitedString[i].Contains(splitedString[i].ToLower()))
            {
               count++;
            }
         }
         Console.WriteLine("Количество слов в строке начинающихся с маленькой буквы: {0}", count);
         Console.WriteLine("Нажмите любую клавишу");
         Console.ReadKey();
      }
   }
}
