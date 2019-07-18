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
        public static T[] ShellSort<T>(T[] array) where T : IComparable
        {
            for (int step = array.Length >> 1; step > 0; step >>= 1)
            {
                for (int i = 0; i < step; i++)
                {
                    for (int j = i + step; j < array.Length; j += step)
                    {
                        int k = j;
                        T value = array[j];//待插入的值
                        while (k >= step && array[k - step].CompareTo(value) > 0)
                        {
                            array[k] = array[k - step];//将前面已排序队列 中大于value的数 往后挪一个step
                            k -= step;
                        }
                        array[k] = value;
                    }
                }
            }
            return array;
        }
    }
}
