using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortQuick.Learning
{
    internal class QuickSortLearn3
    {
        private void Partition(int[] array, int low, int high)
        {
            Action<int, int> swap = (x, y) => throw new Exception();
            int paritionPoint = low;
            int leftIterator = low;
            int rightIterator = high;

            while (leftIterator <= rightIterator)
            {
                while (array[leftIterator] < array[paritionPoint])
                {
                    leftIterator++;
                }
                while (array[paritionPoint] < array[rightIterator])
                {
                    rightIterator--;
                }

                if (leftIterator <= rightIterator)
                {
                    swap(leftIterator, rightIterator);
                    leftIterator++;
                    rightIterator--;
                }
            }

            if (leftIterator < high) { Partition(array, leftIterator, high); }
            if (low < rightIterator) { Partition(array, low, rightIterator); }
        }

        public void Sort(int[] array)
        {
            Partition(array, 0, array.Length - 1);
        }
    }
}
