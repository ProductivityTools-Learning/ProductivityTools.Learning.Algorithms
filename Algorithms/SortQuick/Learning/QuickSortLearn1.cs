using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortQuick.Learning
{
    internal class QuickSortLearn1
    {
        public void Sort(int[] array, int low, int high)
        {
            Action<int, int> swap = null;

            int partitionPoint = low;
            int leftIterator = low;
            int rightIterator = high;

            while (leftIterator <= rightIterator)
            {
                while (array[leftIterator] < array[partitionPoint])
                {
                    leftIterator++;
                }
                while (array[partitionPoint] < array[rightIterator])
                {
                    rightIterator--;
                }

                if (leftIterator <= rightIterator)
                {
                    swap(leftIterator, rightIterator);
                    leftIterator++;
                    rightIterator--;
                }

                if (leftIterator < partitionPoint) { Sort(array, leftIterator, partitionPoint); }//!!!!
                if (partitionPoint < rightIterator) { Sort(array, partitionPoint, rightIterator); }//!!!
            }
        }
        public void Sort(int[] array)
        {
            Sort(array, 0, array.Length);
        }
    }
}
