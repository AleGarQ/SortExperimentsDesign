using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SortTest.test
{
    [TestClass]
    public class QuickTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            long[] elements = { 2, 1 };
            QuickSort sort = new QuickSort();
            sort.sort(elements,0,elements.Length-1);
            long[] elements2 = { 1, 2 };
            CollectionAssert.AreEqual(elements,elements2);

        }

        [TestMethod]

        public void TestMethod100asc()
        {
            long[] array = new long[100];
            for(long i = 0; i < 100; i++)
            {
                array[i] = i;
            }
            long[] array2 = array;
            QuickSort sort = new QuickSort();
            CollectionAssert.AreEqual(array,array2);
        }

        
        [TestMethod]

        public void TestMethod1000asc()
        {
            long[] array = new long[1000];
            for(long i = 0; i < 1000; i++)
            {
                array[i] = i;
            }
            long[] array2 = array;
            QuickSort sort = new QuickSort();
            CollectionAssert.AreEqual(array,array2);
        }

        [TestMethod]

        public void TestMethod10000asc()
        {
            long[] array = new long[10000];
            for(long i = 0; i < 10000; i++)
            {
                array[i] = i;
            }
            long[] array2 = array;
            QuickSort sort = new QuickSort();
            CollectionAssert.AreEqual(array,array2);
        }

        [TestMethod]

        public void TestMethod1000000asc()
        {
            long[] array = new long[1000000];
            for(long i = 0; i < 1000000; i++)
            {
                array[i] = i;
            }
            long[] array2 = array;
            QuickSort sort = new QuickSort();
            CollectionAssert.AreEqual(array,array2);
        }

    }
}
