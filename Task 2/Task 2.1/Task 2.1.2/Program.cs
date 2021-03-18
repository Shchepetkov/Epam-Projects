using System;
using System.Collections.Generic;
using System.Linq;
using Epam.Task_2.Task_2_1.Task_2_1_2.Cases;

namespace Epam.Task_2.Task_2_1.Task_2_1_2
{
   class Program
   {
      static void Main(string[] args)
      {
         List<string> figuresName = new List<string>() { "1.Линия", "2.Треугольник", "3.Квадрат", "4.Прямоугольник",
                "5.Окружность", "6.Круг", "7.Кольцо" };
         ListFigures list = new ListFigures();
         ListFigures activeList = list;
         while (true)
         {
            Console.WriteLine("Выберите действие:" + Environment.NewLine + "1.Добавить фигуру" + Environment.NewLine
                            + "2.Вывести фигуры" + Environment.NewLine + "3.Очистить поле" + Environment.NewLine
                            + "4.Выход" + Environment.NewLine);

            int read = Convert.ToInt32(Console.ReadLine());
            switch (read)
            {
               case 1:
                  Case1 case1 = new Case1(); case1.Action(figuresName);
                  int read2 = Convert.ToInt32(Console.ReadLine());
                  Console.Clear();
                  switch (read2)
                  {
                     case 1:
                        CaseToCase1 caseTo1 = new CaseToCase1(); caseTo1.Action(activeList);
                        Console.Clear(); break;
                     case 2:
                        CaseToCase2 caseTo2 = new CaseToCase2(); caseTo2.Action(activeList);
                        Console.Clear(); break;
                     case 3:
                        CaseToCase3 caseTo3 = new CaseToCase3(); caseTo3.Action(activeList);
                        Console.Clear(); break;
                     case 4:
                        CaseToCase4 caseTo4 = new CaseToCase4(); caseTo4.Action(activeList);
                        Console.Clear(); break;
                     case 5:
                        CaseToCase5 caseTo5 = new CaseToCase5(); caseTo5.Action(activeList);
                        Console.Clear(); break;
                     case 6:
                        CaseToCase6 caseTo6 = new CaseToCase6(); caseTo6.Action(activeList);
                        Console.Clear(); break;
                     case 7:
                        CaseToCase7 caseTo7 = new CaseToCase7(); caseTo7.Action(activeList);
                        Console.Clear(); break;
                  }
                  break;
               case 2:
                  Case2 case2 = new Case2(); case2.Action(activeList);
                  break;
               case 3:
                  activeList.ClearList();
                  Console.Clear(); break;
               case 4:
                  return;
            }
         }
      }
   }
}