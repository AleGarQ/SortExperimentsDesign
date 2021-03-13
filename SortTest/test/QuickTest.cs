using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExperimentsDesign;
using System;

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

        public void TestMethod1000000desc()
        {
            long[] array = new long[1000000];
            long[] array2 = array;
            for (long i = 999999; i >= 0; i--)
            {
                array[i] = i;
                array2[999999 - i] = i;
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
        //random
        [TestMethod]

        public void TestMethod100rand()
        {
            long[] array = new long[100];
            Random rnd = new Random();
            Boolean ordered = true;
            for (long i = 0; i < 100; i++)
            {
                array[i] = rnd.Next(0, 200);
            }
            QuickSort sort = new QuickSort();
            sort.quickSort(array, 0, array.Length - 1);
            for (long i = 1; i < 100; i++)
            {
                if (array[i - 1] > array[i])
                {
                    ordered = false;

                    break;
                }
            }
            Assert.IsTrue(ordered);
        }

        [TestMethod]

        public void TestMethod1000rand()
        {
            long[] array = new long[1000];
            Random rnd = new Random();
            Boolean ordered = true;
            for (long i = 0; i < 1000; i++)
            {
                array[i] = rnd.Next(0, 2000);
            }
            QuickSort sort = new QuickSort();
            sort.quickSort(array, 0, array.Length - 1);
            for (long i = 1; i < 1000; i++)
            {
                if (array[i - 1] > array[i])
                {
                    ordered = false;
                    Console.Write(array[i - 1] + " " + array[i]);
                    break;
                }
            }
            Assert.IsTrue(ordered);
        }

        [TestMethod]

        public void TestMethod10000rand()
        {
            long[] array = new long[10000];
            Random rnd = new Random();
            Boolean ordered = true;
            for (long i = 0; i < 10000; i++)
            {
                array[i] = rnd.Next(0, 20000);
            }
            QuickSort sort = new QuickSort();
            sort.quickSort(array, 0, array.Length - 1);
            for (long i = 1; i < 10000; i++)
            {
                if (array[i - 1] > array[i])
                {
                    ordered = false;
                    break;
                }
            }
            Assert.IsTrue(ordered);
        }

        [TestMethod]

        public void TestMethod1000000rand()
        {
            long[] array = new long[1000000];
            Random rnd = new Random();
            Boolean ordered = true;
            for (long i = 0; i < 1000000; i++)
            {
                array[i] = rnd.Next(0, 20000);
            }
            QuickSort sort = new QuickSort();
            sort.quickSort(array, 0, array.Length - 1);
            for (long i = 1; i < 1000000; i++)
            {
                if (array[i - 1] > array[i])
                {
                    ordered = false;
                    break;
                }
            }
            Assert.IsTrue(ordered);
        }
        //Stiven Arboleda
    }
}