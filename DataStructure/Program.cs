﻿using System;
using System.Collections.Generic;

namespace DataStructure
{
     class Program
    {

        static void Main(string[] args)
        {
            RBT<int> rbt = new RBT<int>();
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < a.Length; i++)
                rbt.Add(a[i]);

            Console.WriteLine(rbt.MaxHeight());


            Console.Read();
        }
    }
}
