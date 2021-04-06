using System;
using Task_3._2;

namespace Task_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DynamicArray<int> dynamicArray = new DynamicArray<int>();

            dynamicArray.Add(51);
            dynamicArray.Add(52);
            dynamicArray.Add(53);

            foreach (var item in dynamicArray)
            {
                Console.WriteLine(item);
            }
        }

    }
}
