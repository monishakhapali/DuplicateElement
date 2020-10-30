using System;
using System.Collections.Generic;
using System.Linq;

namespace DuplicateElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            /*Given an array of integers nums containing n + 1 integers where each integer is in the range [1, n] inclusive.
            There is only one duplicate number in nums, return this duplicate number.
            */
            int[] a = { 1, 2, 2, 3, 4 };
            Console.WriteLine(FindDuplicate(a));
            Console.ReadLine();
        }
        public static int FindDuplicate(int[] a)
        {
            HashSet<int> numset = new HashSet<int>();
            
            for(int i=0;i<a.Length;i++)
            {
                if (numset.Contains(a[i]))
                {

                  
                   
                    return a[i];
                }
                numset.Add(a[i]);
            }
            return -1;
        }
    }
}
