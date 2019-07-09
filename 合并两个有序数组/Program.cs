using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 合并两个有序数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 3, 5, 7, 9 };
            int[] array2 = new int[] { 2, 4, 6, 8, 10 };
            int[] array = MergeTwoArray(array1, array2);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static int[] MergeTwoArray(int[] array1,int[] array2)
        {
            int n = array1.Length + array2.Length;
            int[] array3 = new int[n];
            int j = 0, k = 0;
            for (int i = 0; i < n; i++)
            {
                if(j< array1.Length && k< array2.Length)
                {
                    if (array1[j] < array2[k])
                    {
                        array3[i] = array1[j];
                        j++;
                    }
                    else
                    {
                        array3[i] = array2[k];
                        k++;
                    }
                }
                else if(j < array1.Length)
                {
                    array3[i] = array1[j];
                    j++;
                }
                else if(k < array2.Length)
                {
                    array3[i] = array2[k];
                    k++;
                }
            }

            return array3;
        }
    }
}
