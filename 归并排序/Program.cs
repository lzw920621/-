using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 归并排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 1, 9, 6, 5, 4, 2 };

            MergeSort(array);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static void MergeSort(int[] array,int left,int right)
        {
            if(left<right)
            {
                int q = (left + right) / 2;
                MergeSort(array, left, q);
                MergeSort(array, q+1, right);
                Merge(array, left, q, right);
            }
        }

        static void Merge(int[] array,int left,int q,int right)//合并两个有序序列
        {
            int n1 = q - left + 1;
            int n2 = right - q;
            int[] array1 = new int[n1 + 1];
            int[] array2 = new int[n2 + 1];
            for (int i = 0; i < n1; i++)
            {
                array1[i] = array[left + i];
            }
            for (int i = 0; i < n2; i++)
            {
                array2[i] = array[q + 1 + i];
            }
            array1[n1] = int.MaxValue;
            array2[n2] = int.MaxValue;

            int m = 0, n = 0;
            for (int i = left; i <= right; i++)
            {
                if(array1[m]<=array2[n])
                {
                    array[i] = array1[m];
                    m++;
                }
                else
                {
                    array[i] = array2[n];
                    n++;
                }
            }
        }


        static void MergeSort(int[] array)
        {
            int[] tempArray = new int[array.Length];//提前分配的临时数组(用来存放 合并后的有序序列) 避免每次在merge方法里分配两个新数组 提高效率
            MergeSort_Assist(array, 0, array.Length - 1, tempArray);
        }
        static void MergeSort_Assist(int[] array,int left,int right, int[] tempArray)
        {
            if(left<right)
            {
                int midIndex = (left + right) / 2;
                MergeSort_Assist(array, left, midIndex, tempArray);
                MergeSort_Assist(array, midIndex + 1, right, tempArray);
                Merge_(array, left, midIndex, right, tempArray);
            }
        }
        static void Merge_(int[] array,int left,int mid,int right,int[] tempArray)
        {
            int i = left;
            int j = mid + 1;
            int index = 0;
            while(i<=mid && j<=right)
            {
                if(array[i]<array[j])
                {
                    tempArray[index] = array[i];
                    i++;
                    index++;
                }
                else
                {
                    tempArray[index] = array[j];
                    j++;
                    index++;
                }
            }
            while(i<=mid)
            {
                tempArray[index] = array[i];
                i++;
                index++;
            }
            while(j<=right)
            {
                tempArray[index] = array[j];
                j++;
                index++;
            }

            for (int k = 0; k <index; k++)//将临时数组tempArray中合并好的元素放到 原数组array中
            {
                array[left + k] = tempArray[k];
            }
        }
    }
}
