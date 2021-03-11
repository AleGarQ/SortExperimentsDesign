using System;

namespace ExperimentsDesign
{
    public class InsertionSort
    {
        public InsertionSort() 
        { 
            
        }

        public void sort(long[] arr) 
        {
            long n = arr.Length;
            for (long i = 1; i < n; ++i)
            {
                long key = arr[i];
                long j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }

        }
    }
}
