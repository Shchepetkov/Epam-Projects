using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_1.Task_1_2
{
   public class Averages
   {
      public void m()
      {
         Console.Write("Введите предложение: ");
         string Input = Console.ReadLine();
         StringBuilder StringBuilder = new StringBuilder();

         foreach (char symbol in Input)
         {
            if (!char.IsPunctuation(symbol))
               StringBuilder.Append(symbol);
         }

         string[] StringSplit = StringBuilder.ToString().Split(new char[] { ' ' });
         int CountWord = 0;
         int LengthWords = 0;

         foreach (string Word in StringSplit)
         {
            CountWord++;
         }

         foreach (string Word in StringSplit)
         {
            LengthWords += Word.Length;
         }
         Console.WriteLine("Средняя длина слова = " + LengthWords / CountWord); // Результат целый

      }
   }
}
