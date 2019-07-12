using System;

namespace 快速排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //9, 2, 4, 1, 5, 2, 8, 7, -1, 20, 11, 6
            QuickSort(new int[] { 9, 2, 4, 1, 5, 2, 8, 7, -1, 20, 11, 6 });
        }

        public static void QuickSort(int[] array)
        {
            Partition(array, 0, array.Length - 1);            
        }
        static void Partition(int[] array, int left, int right)
        {
            if (left >= right) return;

            int pivot = array[left];
            int l = left, r = right;
            while(l<r)
            {
                while(l<r && array[r] >= pivot)
                {
                    r--;
                }
                array[l] = array[r];
                while(l<r && array[l] <= pivot)
                {
                    l++;
                }
                array[r] = array[l];
            }
            array[l] = pivot;

            Partition(array, left, l - 1);
            Partition(array, l + 1, right);
        }
        
    }

    
}
