using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopK算法
{
    //从N个数中查找前K个最大的

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 10, 2, 20, 3, 30, 4, 40, 5, 50, 6, 60, 7, 70, 8, 80, 9, 90 };
            int k = 10;

            TopK(array, 0, array.Length - 1, k);

        }

        public static void TopK(int[] data, int low, int high, int k)//利用快速排序的思路来实现 时间复杂度O(n)
        {
            int left = low;
            int right = high;
            int mid = data[low];
            while (left < right)
            {
                while (left < right && data[right] <= mid)
                {
                    right--;
                }
                if (left < right)
                {
                    data[left] = data[right];
                    left++;
                }
                while (left < right && data[left] >= mid)
                {
                    left++;
                }
                if (left < right)
                {
                    data[right] = data[left];
                    right--;
                }
            }
            data[left] = mid;
            if (left > k)
            {
                TopK(data, low, left - 1, k);
            }
            else if (left < k)
            {
                TopK(data, left + 1, high, k);
            }
        }

    }
}
