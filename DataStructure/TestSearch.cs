using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// 二分查找
    /// </summary>
    class TestSearch
    {
        /// <summary>
        /// 二分查找
        /// </summary>
        public static int BinarySearch(int[] arr,int target)
        {
            int left = 0; //左指针
            int right = arr.Length - 1;//右指针

            while (left<=right)
            {
                int mid = left + (right - left) / 2;//中间指针

                if (target < arr[mid])
                {
                    mid = right - 1;
                }else if (target >arr[ mid])
                {
                    mid = left + 1;
                }
                else
                {
                    return mid;
                }
               
            }
            return -1;
        }
    }
}
