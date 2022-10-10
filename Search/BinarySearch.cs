using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Search
{
    public static class BinarySearch
    {

        //To Use This Function You Have To Pass A Sorted Array
        public static int Search(int[] SortedArray, int SearchedItem)
        {
            int IndexOfSearchedItem = -1; //It Means The Searched Item Is Not Existed In The Array
            int high = SortedArray.Length - 1;
            int low = 0;
            while (high >= low)
            {
                int mid = (int)((high + low) / 2);
                if (SearchedItem == SortedArray[mid])
                {
                    IndexOfSearchedItem = mid;
                    return IndexOfSearchedItem;
                }
                if (SearchedItem > SortedArray[mid])
                    low = mid + 1;
                else if (SearchedItem < SortedArray[mid])
                    high = mid - 1;
            }
            return IndexOfSearchedItem;
        }
    }
}
