using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3
{
    public static class AllTypeExtension
    {
        private static readonly Random RandomGenerator = new();

        /// <summary>
        /// Возвращает рандомно одно число из всех чисел имеющихся в массиве
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <returns></returns>
        public static T Random<T>(this T[] array)
        {
            return array[RandomGenerator.Next(0, array.Length)];
        }

        /// <summary>
        ///  Возвращает среднее значение
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static double FindAverage(this int[] arr)
        {
            double average = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                average += arr[i];
            }
            return average / arr.Length;
        }

        /// <summary>
        /// Создает рандомный массив от Random.Next(min, max)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static string FillRandom(this int[] array, int min, int max)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = RandomGenerator.Next(min, max);
            }
            return string.Join(", ", array);
        }

        public static void MultiplyNumberByTwo(this int[] array)
        {
            double mult = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    mult *= array[i];
            }

            Console.WriteLine(mult);

        }

        public static int Sum(this int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        public static void Partition(this int[] array, Func<int, int> compare)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = compare(array[i]);
                Console.WriteLine(array[i]);
            }
  
        }

    }
}
