using System;

namespace Sorting1
{
    class Program
    {
        static void Main(string[] args)
        {

            int [] a = { 1,2,5,7,3};
            MergeSort1.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    
    }
}
