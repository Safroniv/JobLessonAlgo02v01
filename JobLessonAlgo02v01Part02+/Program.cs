using System;

namespace JobLessonAlgo02v01Part02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[] { 1, 2, 3, 67, 33, 5, 65, 34, 10 };
            Array.Sort(testArray);            
            Console.WriteLine(BinarySearch(testArray, 67));
            Console.ReadLine();
            //Бинарный поиск ищет не перебирая все значения,
            //а разделяя массив на под массивы, каждый раз деля поиск пополам
            //Сложность самого поиска O(log(N)),
            //но если учитывать необходимость сортировки массива,
            //то будет влиять метод сортировки, который варьируется от O(N) до O(N^2). 

        }
        /// <summary>
        /// Бинарный поиск. выполняется путём деления массива по среднему элементу.
        /// Поиск очень удобен, но массив должен быть упорядоченным,
        /// В противном случае может выдаватся некорректный результат.
        /// </summary>
        /// <param name="inputArray">массив на входе</param>
        /// <param name="searchValue">искомое значение</param>
        /// <returns></returns>
        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid= (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
