using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 堆排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 2, 4, 1, 5, 2, 8, 7, -1, 20, 11, 6 };
            HeapSortFunction(array);
        }

        //堆排序
        private static void HeapSortFunction(int[] array)
        {
            BuildMaxHeap(array);    //创建大顶推（初始状态看做：整体无序）
            for (int i = array.Length - 1; i > 0; i--)
            {
                Swap(array, 0, i); //将堆顶元素(最大值)与无序区的最后一位交换（使堆顶元素进入有序区）
                MaxHeapify(array, 0, i); //重新将无序区调整为大顶堆
            }
        }

        ///<summary>
        /// 创建大顶推（根节点大于左右子节点）
        ///</summary>
        ///<param name="array">待排数组</param>
        private static void BuildMaxHeap(int[] array)
        {
            //根据大顶堆的性质可知：数组的前半段的元素为非根节点，其余元素都为叶节点
            for (int i = array.Length / 2 - 1; i >= 0; i--) //从最底层的最后一个非根节点开始进行大顶推的调整
            {
                MaxHeapify(array, i, array.Length); //调整大顶堆
            }
        }

        ///<summary>
        /// 大顶推的调整过程
        ///</summary>
        ///<param name="array">待调整的数组</param>
        ///<param name="currentIndex">待调整元素在数组中的位置（即：根节点）</param>
        ///<param name="heapSize">堆中所有元素的个数</param>
        private static void MaxHeapify(int[] array, int currentIndex, int heapSize)
        {
            int leftIndex = 2 * currentIndex + 1;    //左子节点在数组中的位置
            int rightIndex = 2 * currentIndex + 2;   //右子节点在数组中的位置
            int largeIndex = currentIndex;   //记录此根节点、左子节点、右子节点 三者中最大值的位置

            if (leftIndex < heapSize && array[leftIndex] > array[largeIndex])  //与左子节点进行比较
            {
                largeIndex = leftIndex;
            }
            if (rightIndex < heapSize && array[rightIndex] > array[largeIndex])    //与右子节点进行比较
            {
                largeIndex = rightIndex;
            }
            if (currentIndex != largeIndex)  //如果 currentIndex != largeIndex 则表明 largeIndex 发生变化（即：左右子节点中有大于根节点的情况）
            {
                Swap(array, currentIndex, largeIndex);    //将左右节点中的大者与根节点进行交换（即：实现局部大顶堆）
                MaxHeapify(array, largeIndex, heapSize); //以上次调整动作的large位置（为此次调整的根节点位置），进行递归调整
            }
        }

        ///<summary>
        /// 交换数组中的两个元素
        ///</summary>
        ///<param name="indexA">索引A</param>
        ///<param name="indexB">索引B</param>
        private static void Swap(int[] array,int indexA,int indexB)
        {
            if(indexA<0 || indexB<0 || indexA>=array.Length || indexB>=array.Length)
            {
                throw new IndexOutOfRangeException("索引超出数组范围");
            }

            int temp = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = temp;            
        }
    }
}
