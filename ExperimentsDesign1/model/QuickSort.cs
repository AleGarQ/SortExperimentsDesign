using System;

namespace SortTest.test
{
    public class QuickSort
    {
        public QuickSort() { }
        static long Partition(long[] array, long low,
                                     long high)
        {
            long pivot = array[high];

            long lowIndex = (low - 1);

            for (long j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    lowIndex++;

                    long temp = array[lowIndex];
                    array[lowIndex] = array[j];
                    array[j] = temp;
                }
            }

            long temp1 = array[lowIndex + 1];
            array[lowIndex + 1] = array[high];
            array[high] = temp1;

            return lowIndex + 1;
        }

        public void quickSort(long[] array, long low, long high)
        {
            if (low < high)
            {
                long partitionIndex = Partition(array, low, high);

                quickSort(array, low, partitionIndex - 1);
                quickSort(array, partitionIndex + 1, high);
            }
        }
    }
}