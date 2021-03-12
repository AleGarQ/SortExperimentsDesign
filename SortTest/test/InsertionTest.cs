using ExperimentsDesign;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortTest.test
{
    [TestClass]
    public class InsertionTest
    {

        [TestMethod]
        public void TestInsertion()
        {
            long[] elements = { 2, 1 };
            InsertionSort sort = new InsertionSort();
            sort.insSort(elements);
            Console.Write(elements);
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
            InsertionSort sort = new InsertionSort();
            sort.insSort(array);
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
            InsertionSort sort = new InsertionSort();
            sort.insSort(array);
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
            InsertionSort sort = new InsertionSort();
            sort.insSort(array);
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
            InsertionSort sort = new InsertionSort();
            sort.insSort(array);
            CollectionAssert.AreEqual(array, array2);
        }


        [TestMethod]
        public void Test100desc()
        {
            long[] array = new long[100];
            long[] array2 = array;
            for (long i = 99; i >= 0; i--)
            {
                array[i] = i;
                array2[99 - i] = i;
            }
            InsertionSort sort = new InsertionSort();
            sort.insSort(array);
            CollectionAssert.AreEqual(array, array2);
        }

        [TestMethod]
        public void Test1000desc()
        {
            long[] array = new long[1000];
            long[] array2 = array;
            for (long i = 999; i >= 0; i--)
            {
                array[i] = i;
                array2[999 - i] = i;
            }
            InsertionSort sort = new InsertionSort();
            sort.insSort(array);
            CollectionAssert.AreEqual(array, array2);

        }

        [TestMethod]
        public void Test10000desc()
        {
            long[] array = new long[10000];
            long[] array2 = array;
            for (long i = 9999; i >= 0; i--)
            {
                array[i] = i;
                array2[9999 - i] = i;
            }
            InsertionSort sort = new InsertionSort();
            sort.insSort(array);
            CollectionAssert.AreEqual(array, array2);
        }

         [TestMethod]
        public void Test1000000desc()
        {
            long[] array = new long[1000000];
            long[] array2 = array;
            for (long i = 999999; i >= 0; i--)
            {
                array[i] = i;
                array2[999999 - i] = i;
            }
            InsertionSort sort = new InsertionSort();
            sort.insSort(array);
            CollectionAssert.AreEqual(array, array2);
        }
    }
}
