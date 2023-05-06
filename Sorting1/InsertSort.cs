using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting1
{
    //插入排序o（n）**2， 对于几乎有序的数组 速度为O（n）
    class InsertSort
    {
     public static void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int e = arr[i]; //抽取一个数 ：值
                int j;//插入位置 ：索引位置

                for ( j = i; j >0; j--)
                {
                    if (e < arr[j - 1])
                    {
                        arr[j] = arr[j - 1];
                    }
                    else
                    {
                        break;
                    }
                }
                //内层循环停止，位置元素互换
                arr[j] = e;
            }
        }
    }
}
