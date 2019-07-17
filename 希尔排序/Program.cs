using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 希尔排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 2, 4, 1, 5, 2, 8, 7, -1, 20, 11, 6 };
            ShellSort(array);
        }

        /// <summary>
        /// 希尔排序
        /// </summary>
        public static T[] ShellSort<T>(T[] arr) where T : IComparable
        {
            for (int step = arr.Length >> 1; step > 0; step >>= 1)
            {
                for (int i = 0; i < step; ++i)
                {
                    for (int j = i + step; j < arr.Length; j += step)
                    {
                        int k = j;
                        T value = arr[j];
                        while (k >= step && arr[k - step].CompareTo(value) > 0)
                        {
                            arr[k] = arr[k - step];
                            k -= step;
                        }
                        arr[k] = value;
                    }
                }
            }
            return arr;
        }
    }
}
