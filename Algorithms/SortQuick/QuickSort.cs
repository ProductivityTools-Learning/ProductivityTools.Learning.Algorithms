using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortQuick
{
    internal class QuickSort
    {


        private int Partition(int[] array, int low, int high)
        {
            Action<int, int> swap = (a, b) =>
            {
                int temp = array[a];
                array[a] = array[b];
                array[b] = temp;
            };

            int partitionPoint = low;
            int partitionValue = array[partitionPoint];

            int leftIterator = low + 1;
            int rightIterator = high;


            while (leftIterator <= rightIterator)
            {
                while (array[leftIterator] < partitionValue && leftIterator < rightIterator)
                {
                    leftIterator++;
                }

                while (partitionValue < array[rightIterator] && leftIterator < rightIterator)
                {
                    rightIterator--;
                }
                
                swap(leftIterator, rightIterator);
                leftIterator++;
                rightIterator--;
            }
            swap(partitionPoint, rightIterator);
            return rightIterator;
        }

        private void Sort(int[] array,int low, int high)
        {
            if (low >= high){return;}

            var partitionPoint=Partition(array, low, high);
            Sort(array, low,partitionPoint);
            Sort(array, partitionPoint+1, high);
        }

        public void Sort(int[] array)
        {
            Sort(array, 0, array.Length-1);
        }
    }
}
