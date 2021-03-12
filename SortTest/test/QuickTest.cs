using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExperimentsDesign;

namespace SortTest.test
{
    [TestClass]
    public class QuickTest
    {
        [TestMethod]
        public void TestQuick ()
        {
            long[] elements = { 2, 1 };
            QuickSort sort = new QuickSort();
            sort.quickSort(elements, 0, elements.Length - 1);
            long[] elements2 = { 1, 2 };
            CollectionAssert.AreEqual(elements, elements2);
        }

        [TestMethod]
        public void Test100asc()
        {
            long[] array = new long[100];
            for (long i = 0; i < 100; i++)
            {
                array[i] = i;
            }
            long[] array2 = array;
            QuickSort sort = new QuickSort();
            CollectionAssert.AreEqual(array, array2);
        }


        [TestMethod]
        public void Test1000asc()
        {
            long[] array = new long[1000];
            for (long i = 0; i < 1000; i++)
            {
                array[i] = i;
            }
            long[] array2 = array;
            QuickSort sort = new QuickSort();
            CollectionAssert.AreEqual(array, array2);
        }

        [TestMethod]
        public void Test10000asc()
        {
            long[] array = new long[10000];
            for (long i = 0; i < 10000; i++)
            {
                array[i] = i;
            }
            long[] array2 = array;
            QuickSort sort = new QuickSort();
            CollectionAssert.AreEqual(array, array2);
        }

        [TestMethod]
        public void Test1000000asc()
        {
            long[] array = new long[1000000];
            for (long i = 0; i < 1000000; i++)
            {
                array[i] = i;
            }
            long[] array2 = array;
            QuickSort sort = new QuickSort();
            CollectionAssert.AreEqual(array, array2);
        }

        //descen
        [TestMethod]

        public void TestMethod10desc()
        {
            long[] array = new long[10];
            long[] array2 = array;
            for (long i = 9; i >= 0; i--)
            {
                array[i] = i;
                array2[9 - i] = i;
            }
            QuickSort sort = new QuickSort();
            sort.quickSort(array, 0, array.Length - 1);
            CollectionAssert.AreEqual(array, array2);

        }

        [TestMethod]

        public void TestMethod100desc()
        {
            long[] array = new long[100];
            long[] array2 = array;
            for (long i = 99; i >= 0; i--)
            {
                array[i] = i;
                array2[99 - i] = i;
            }
            QuickSort sort = new QuickSort();
            sort.quickSort(array, 0, array.Length - 1);
            CollectionAssert.AreEqual(array, array2);

        }

        [TestMethod]

        public void TestMethod1000desc()
        {
            long[] array = new long[1000];
            long[] array2 = array;
            for (long i = 999; i >= 0; i--)
            {
                array[i] = i;
                array2[999 - i] = i;
            }
            QuickSort sort = new QuickSort();
            sort.quickSort(array, 0, array.Length - 1);
            CollectionAssert.AreEqual(array, array2);

        }

        [TestMethod]

        public void TestMethod10000desc()
        {
            long[] array = new long[10000];
            long[] array2 = array;
            for (long i = 9999; i >= 0; i--)
            {
                array[i] = i;
                array2[9999 - i] = i;
            }
            QuickSort sort = new QuickSort();
            sort.quickSort(array, 0, array.Length - 1);
            CollectionAssert.AreEqual(array, array2);

        }
    }
}
