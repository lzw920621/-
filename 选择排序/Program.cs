using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 选择排序
{
    /*
    首先在未排序序列中找到最小元素，存放到排序序列的起始位置。
    再从剩余未排序元素中继续寻找最小元素，然后放到已排序序列的末尾。
    重复第二步，直到所有元素均排序完毕。
    */
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 1, 6, 4, 2, 8, 5 };
            SelectSort(array);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static int[] SelectSort(int[] array)
        {
            int index = 0;//每次找到的 最小值 的索引
            int temp;//临时值 存储每一次找到的最小值

            
            for (int i = 0; i < array.Length-1; i++)//i表示 未排序 序列的起始索引(同时也是 已排序序列 的末尾索引)
            {
                temp = array[i];//temp初始值设为未排序序列的第一个元素值                
                for (int j = i+1; j < array.Length; j++)//从未排序序列中找一个最小值的索引
                {
                    if(array[j]<temp)
                    {                        
                        index = j;//最小值的索引
                    }
                }
                if(i!=index)
                {
                    //交换找到的最小值 和 array[i]
                    temp = array[index];
                    array[index] = array[i];
                    array[i] = temp;
                }                
            }
            return array;
        }
    }
}
