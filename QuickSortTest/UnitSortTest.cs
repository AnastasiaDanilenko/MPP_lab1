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
    }
}
