using System;
using Task_3._3;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = new int[] { 1, 2, 3, 4, 5 };
            /*            Console.WriteLine(s.Random<int>());
                        Console.WriteLine(s.FindAverage());
                        Console.WriteLine(s.FillRandom(1, 7));
                        s.MultiplyNumberByTwo();*/

            s.Partition(Square);
        }

        static int Square(int x) => x * x;
    }
}
