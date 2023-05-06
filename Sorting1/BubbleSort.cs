using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting1
{
    class BubbleSort
    {
        public static void Sort(int[] arr) 
        {
            int n = arr.Length;

            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j<n-1-i; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        Swap(arr, j, j + 1);
                    }
                }
            }
        }

       static public void Swap(int[]arr,int i,int j)
        {
            int e;
                e = arr[i];
                arr[i] = arr[j];
                arr[j] = e;

        }
    }
}
