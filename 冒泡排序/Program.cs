using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 2, 4, 1, 5, 2, 8, 7, -1, 20, 11, 6 };
            BubbleSort(array);
        }

        public static void BubbleSort(int[] array)
        {
            int temp = 0;
            bool swapped;//标志位 是否交换过 (增加该标志位是为了提高排序的效率,尤其是对那些很多元素已经有序的数组)
            for (int i = 0; i < array.Length-1; i++)  //i 表示第i趟 每一趟确定一个最大值 (n个元素的数组只需要n-1趟)
            {
                swapped = false;//每一趟将标志位置为false
                for (int j = 0; j < array.Length-i-1; j++)
                {
                    if(array[j]>array[j+1])
                    {
                        temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                        swapped = true;//已交换
                    }
                }
                if(swapped==false)//这一趟未发生交换 说明排序已完成 直接返回
                {
                    return;
                }
            }
        }
    }
}
