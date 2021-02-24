using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epam.Task_1.Task_1_1
{
   public class Font_Adjustment
   {
      public void m(int n)
      {
         List<string> list = new List<string>();
         do
         {
            switch (n)
            {
               case 1:
                  if (list.Contains("Bold")) list.Remove("Bold");
                  else
                  {
                     list.Add("Bold");
                  }
                  Console.WriteLine(string.Join(", ", list));
                  break;
               case 2:
                  if (list.Contains("Italick")) list.Remove("Italick");
                  else
                  {
                     list.Add("Italick");
                  }
                  Console.WriteLine(string.Join(", ", list));
                  break;
               case 3:
                  if (list.Contains("Underline")) list.Remove("Underline");
                  else
                  {
                     list.Add("Underline");
                  }
                  Console.WriteLine(string.Join(", ", list));
                  break;
            }
         }
         while (int.TryParse(Console.ReadLine(), out n));

      }
   }
}
