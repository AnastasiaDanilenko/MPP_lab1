using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSort;

namespace QuickSortTest
{
    [TestClass]
    public class UnitSortTest
    {
        QuickSortClass quicksort = new QuickSortClass(5);
       [TestMethod]
        public void TestOnEqualty()
        {
            int[] hasEqual = {2, 10, 4, 2, 10};
            int[] correctResult = { 2, 2, 4, 10, 10 };
            int[] result = quicksort.StartSorting(hasEqual);
            CollectionAssert.AreEqual(correctResult, result);
        }

        [TestMethod]
        public void TestOnAllEqual()
        {
            int[] allEqual = { 2, 2, 2, 2, 2 };
            int[] correctResult = { 2, 2, 2, 2, 2 };
            int[] result = quicksort.StartSorting(allEqual);
            CollectionAssert.AreEqual(correctResult, result);
        }

        [TestMethod]
        public void SimpleTestOnCorrection()
        {
            int[] justArray = {10, 2, 0, -222, 132 };
            int[] correctResult = { -222, 0, 2, 10, 132 };
            int[] result = quicksort.StartSorting(justArray);
            CollectionAssert.AreEqual(correctResult, result);
        }

        [TestMethod]
        public void ReverseArrayTest()
        {
            int[] justArray = { 999, 232, 90, 22, -132 };
            int[] correctResult = { -132, 22, 90, 232, 999 };
            int[] result = quicksort.StartSorting(justArray);
            CollectionAssert.AreEqual(correctResult, result);
        }
    }
}
