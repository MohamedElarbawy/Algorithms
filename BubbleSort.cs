using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class BubbleSort
    {
      
        public static int[] Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                        Swap(ref arr[j],ref arr[j + 1]);
                }
            }
            return arr;
        }


        public static void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }


    }
}
