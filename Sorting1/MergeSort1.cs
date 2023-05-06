using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting1
{
    /// <summary>
    /// 并归排序1
    /// </summary>
    class MergeSort1
    {
         public static void Sort(int[] arr)
        {
            int n = arr.Length;
            int[] temp = new int[n];
            Sort(arr, temp,0, n - 1);

        }

        private static void Sort(int[] arr,int[] temp,int l,int r)
        {
            int mid = l + (r - l) / 2;
            Merge(arr, temp, l, mid, r);
        }
        private static void Merge(int[]arr,int[] temp,int l,int mid,int r)
        {
            int k = l;
            int i=l;
            int j = mid+1;

            while (i <= mid && j <= r)
            {
                if (arr[i] < arr[j])
                {
                    temp[k] = arr[i];
                    k++;
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    k++;
                    j++;
                }
            }
            //只剩下左边部分
            while (i <= mid)
            {
                temp[k] = arr[i];
                k++;
                i++;
            }
            //只剩下右边部分
            while (j <= r)
            {
                temp[k] = arr[j];
                k++;
                j++;
            }

            for (int z = l; z <=r; z++)
            {
                arr[z] = temp[z];
            }
        }
    }
}
