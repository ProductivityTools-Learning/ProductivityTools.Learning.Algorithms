using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortQuick.Learning
{
    internal class QuickSortLearn2
    {
        public void Partition(int[] a, int low, int high)
        {
            Action<int, int> swap = null;

            int partitionPoint = low;
            int leftIterator = low;
            int rightIterator = high;

            while (leftIterator <= rightIterator)
            {
                while (a[leftIterator] < a[partitionPoint])
                {
                    leftIterator++;
                }

                while (a[partitionPoint] < a[rightIterator])
                {
                    rightIterator--;
                }

                //swap
                if (leftIterator <= rightIterator)
                {
                    swap(leftIterator, rightIterator);
                    leftIterator++;
                    rightIterator--;
                }
            }

            if (leftIterator < high)
            {
                Partition(a, leftIterator, high);
            }
            if (low < rightIterator)
            {
                Partition(a, low, rightIterator);
            }
        }

        public void Sort(int[] a)
        {
            Partition(a, 0, a.Length - 1);
        }
    }
}
