using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task_1.Task_1_2
{
   public class Validator
   {
      public void m()
      {
         Console.Write("Введите предложение: ");
         string str = Console.ReadLine();
         string[] strSplit = str.Split(new char[] { ' ' });

         for (int i = 0; i < strSplit.Length; i++)
         {
            if (i == 0)
            {
               strSplit[i] = strSplit[i].ToUpper();
            }
            if (strSplit[i].Substring(strSplit[i].Length - 1) == "." || strSplit[i].Substring(strSplit[i].Length - 1) == "?" || strSplit[i].Substring(strSplit[i].Length - 1) == "!")
            {
               if (i + 1 < strSplit.Length)
               {
                  strSplit[i + 1] = strSplit[i + 1].Substring(0, 1).ToUpper() + strSplit[i + 1].Substring(1, strSplit[i + 1].Length - 1).ToLower();
               }

            }
         }
         Console.WriteLine(string.Join(" ", strSplit));
      }
   }
}