using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting1
{
    /// <summary>
    /// 选择排序 每次找到一个最小值
    /// </summary>
    class SelectSort
    {
        public static void Sort(int [] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int min = i;
                //循环查找最小值的下标
                for (int j = i+1; j < n; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                //i位与最小值互换
                Swap(arr, i, min);
            }

        }

        private static void Swap(int[] arr, int j, int min)
        {
            int e = arr[j];
            arr[j] = arr[min];
            arr[min] = e;
        }
    }
}
