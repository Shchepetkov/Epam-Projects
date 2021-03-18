using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_Projects.Task01
{
   public class MyStringBuilder
   {
      private char[] charStd;

      //   public static bool operator ==(MyStringBuilder obj1, MyStringBuilder obj2)
      //   {
      //       return obj1.Equals(obj2);
      //   }
      
      //   public static bool operator !=(MyStringBuilder obj1, MyStringBuilder obj2)
      //   {
      //       return !obj1.Equals(obj2);
      //   }

      public MyStringBuilder(char[] ar)
      {
         charStd = new char[ar.Length];
         for (int i = 0; i < ar.Length; i++)
         {
            charStd[i] = ar[i];
         }
      }

     public MyStringBuilder MyConcat2(char[] array1, char[] array2)
        {
            charStd = MyAppend(array1).Concat(MyAppend(array2)).ToArray();
            return this;
        }

      public char[] MyAppend(char[] ar)
      {
         charStd = charStd.Concat(ar).ToArray();
         return charStd;
      }

      public bool MyCompare(char[] ar)
      {
         bool areEqual = charStd.SequenceEqual(ar.ToArray());
         return areEqual;
      }
      public char[] ConvertToCharArr()
      {
         return charStd;
      }

      public char[] FromCharArray(char[] array)
        {
            charStd = array;
            return array;
        }

      public int Find(char chars) => Array.IndexOf(charStd, chars);
   }

}
