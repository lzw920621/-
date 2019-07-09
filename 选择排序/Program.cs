using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 选择排序
{
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
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int temp = int.MaxValue;                
                for (int j = i; j < array.Length; j++)
                {
                    if(array[j]<temp)
                    {
                        temp = array[j];
                        index = j;
                    }
                }
                array[index] = array[i];
                array[i] = temp;
            }
            return array;
        }
    }
}
