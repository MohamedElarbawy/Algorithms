using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class SelectionSort
    {

        //{5,3,9,2,1,4,5,8,2,0,1,9,2}
        public static int[] SortASC(List<int> UnsortedList)
        {
            int[] sortedArray = new int[UnsortedList.Count];
            int indexOfSmallest;
            for (int i = 0; i < sortedArray.Length; i++)
            {
                indexOfSmallest = GetIndexOfSmallest(UnsortedList);
                sortedArray[i] = UnsortedList[indexOfSmallest];
                UnsortedList.RemoveAt(indexOfSmallest);
            }

            return sortedArray;
        }

        static int GetIndexOfSmallest(List<int> list)
        {
            int smallest = list[0], indexOfSmallest = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < smallest)
                {
                    smallest = list[i];
                    indexOfSmallest = i;
                }
            }
            return indexOfSmallest;
        } 
        
        public static int[] SortDEC(List<int> UnsortedList)
        {
            int[] sortedArray = new int[UnsortedList.Count];
            int IndexOfBiggest;
            for (int i = 0; i < sortedArray.Length; i++)
            {
                IndexOfBiggest = GetIndexOfBigest(UnsortedList);
                sortedArray[i] = UnsortedList[IndexOfBiggest];
                UnsortedList.RemoveAt(IndexOfBiggest);
            }

            return sortedArray;
        }

        static int GetIndexOfBigest(List<int> list)
        {
            int biggest = list[0], indexOfBiggest = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > biggest)
                {
                    biggest = list[i];
                    indexOfBiggest = i;
                }
            }
            return indexOfBiggest;
        }


    }
}
