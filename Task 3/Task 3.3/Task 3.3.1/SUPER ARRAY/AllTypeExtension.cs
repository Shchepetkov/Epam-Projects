using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public void M<T>(this IEnumerable<T>) 
        {
        }

        public static T Sum<T>(this T[] array) where T : unmanaged
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));

            if (converter.CanConvertFrom(typeof(int)))
            {
                int sum = 0;
                
                for (int i = 0; i < array.Length; i++)
                {
                    int[] result = (int[])converter.ConvertFrom(array);
                    sum += result[i];
                }
                sum = default(int);
                return sum;
            }

            for (int i = 0; i < array.Length; i++)
            {
                converter += array[i];
            }

            return (T)converter;
        }

        public static void Partition<T>(this T[] array, Func<T, T> compare)
        {
            if (compare != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = compare(array[i]);
                    Console.WriteLine(array[i]);
                }
            }
        }

    }
}
