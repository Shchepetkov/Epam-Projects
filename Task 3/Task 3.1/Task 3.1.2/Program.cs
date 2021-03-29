using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task_3._1._2
{
   class Program
   {
      static void Main(string[] args)
      {
         WordFind();
      }

      public static void WordFind()
      {
         string stroka = Console.ReadLine().ToLower();

         List<string> wordList = stroka.Split(new char[] { ' ', ',', '.' },
         StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();

         foreach (string word in wordList)
         {
            var amount = new Regex(word).Matches(stroka).Count;
            Console.WriteLine("{0} - {1}", word, amount);
         }
      }
   }
}
