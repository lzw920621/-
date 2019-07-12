using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计数排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 2, 4, 1, 5, 2, 8, 7, -1, 20, 11, 6 };
            CountingSort(array);
        }

        public static void CountingSort(int[] array)
        {
            int min = array[0], max = array[0];
            for (int i = 0; i < array.Length; i++)//寻找最大和最小值
            {
                if(array[i]<min)
                {
                    min = array[i];                     
                }
                if(array[i]>max)
                {
                    max = array[i];
                }
            }

            int[] newArray = new int[max - min + 1];//这个数组存放 array中每个元素出现的次数 索引为元素值减去min
            for (int i = 0; i < array.Length; i++)
            {
                newArray[array[i] - min]++;
            }

            int index = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                while(newArray[i]>0)
                {
                    array[index] = i + min;
                    index++;
                    newArray[i]--;
                }
            }
        }

    }
}
