using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting1
{
    /// <summary>
    /// 泛型冒泡排序
    /// </summary>
    class BubbleSortGeneric
    {
        public static void Sort<T>(T[] arr) where T:IComparable<T>
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j].CompareTo( arr[j + 1])>0)
                    {
                        Swap(arr, j, j + 1);
                    }
                }
            }
        }

        static public void Swap<T>(T [] arr, int i, int j)
        {
            T e;
            e = arr[i];
            arr[i] = arr[j];
            arr[j] = e;

        }


    }
}

