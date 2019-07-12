using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桶排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 2, 4, 1, 5, 2, 8, 7, -1, 20, 11, 6 };

            BucketSort(array, 4);
        }
        /// <summary>
        /// 桶排序
        /// </summary>
        /// <param name="array">待排序数组</param>
        /// <param name="bucketSize">桶的容量</param>
        public static void BucketSort(int[] array,int bucketSize)
        {
            int min = array[0], max = array[0];
            for (int i = 0; i < array.Length; i++)//寻找最大和最小值
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            int bucketCount = (max - min + 1) / bucketSize;//桶的个数

            List<int>[] listArrray = new List<int>[bucketCount];//初始化桶
            for (int i = 0; i < bucketCount; i++)
            {
                listArrray[i] = new List<int>();
            }

            for (int i = 0; i < array.Length; i++)//遍历array 将元素放入对应的桶中
            {
                int index = (array[i] - min) / bucketSize;//元素对应的桶索引
                listArrray[index].Add(array[i]);//放入桶中
            }
            foreach (var bucket in listArrray)//对每个桶进行排序
            {
                bucket.Sort();
            }

            int _index = 0;
            foreach (var bucket in listArrray)//取出桶中的元素放入原始数组中
            {
                foreach (var item in bucket)
                {
                    array[_index] = item;
                    _index++;
                }
            }
        }
    }
}
