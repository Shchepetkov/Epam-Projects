﻿using System;
using Epam.Task_1.Task_1_1;

namespace Epam
{
   class Program
   {
      static void Main(string[] args)
      {
         // Rectangle task01 = new Rectangle();
         // task01.m();
         // Triangle task02 = new Triangle();
         // task02.m(4);
         // Another_Triangle task03 = new Another_Triangle();
         // task03.m(4);
        //   X_Mas_Tree task04 = new X_Mas_Tree();
        //   task04.m(4);
        //  Sum_OF_Numbers task05 = new Sum_OF_Numbers();
        //  task05.m();
        int n = Convert.ToInt32(Console.ReadLine());
        Font_Adjustment task06 = new Font_Adjustment();
        task06.m(n);
      }
   }
}