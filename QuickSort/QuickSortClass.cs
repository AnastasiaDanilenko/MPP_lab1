using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class QuickSortClass
    {
        private Comparator comparator;
        private int amountParameters;

        public QuickSortClass(int amount)
        {
            amountParameters = amount;
        }

        public void StartSorting(int[] arrayToSort)
        {
            Sort(arrayToSort, 0, arrayToSort.Count());
        }

        private void Sort(int[] arrayToSort, int left, int right)
        {
            int temp;
            int x = arrayToSort[left + (right - left) / 2];
            int i = left;
            int j = right;
            while (i <= j)
            {
                while (arrayToSort[i] < x) i++;
                while (arrayToSort[j] > x) j--;
                if (i <= j)
                {
                    temp = arrayToSort[i];
                    arrayToSort[i] = arrayToSort[j];
                    arrayToSort[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < right)
                Sort(arrayToSort, i, right);

            if (left < j)
                Sort(arrayToSort, left, j);
        }


    }
}
