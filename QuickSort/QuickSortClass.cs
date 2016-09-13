using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class QuickSortClass
    {
        private Comparator comparator = new Comparator();
        private int amountParameters;

        public QuickSortClass(int amount)
        {
            amountParameters = amount;
        }

        public int[] StartSorting(int[] arrayToSort)
        {
            arrayToSort = Sort(arrayToSort, 0, arrayToSort.Count()-1);
            return arrayToSort;
        }

        private int[] Sort(int[] arrayToSort, int left, int right)
        {
            int temp;
            int x = arrayToSort[left + (right - left) / 2];
            int i = left;
            int j = right;
            while (i <= j)
            {
                while (comparator.Compare(arrayToSort[i], x) == -1) i++;
                while (comparator.Compare(arrayToSort[j], x) == 1) j--;
                if (i <= j)
                {
                    temp = arrayToSort[i];
                    arrayToSort[i] = arrayToSort[j];
                    arrayToSort[j] = temp;
                    i++;
                    j--;
                }
            }
            if (comparator.Compare(i, right) == -1)
                Sort(arrayToSort, i, right);

            if (comparator.Compare(left, j) == -1)
                Sort(arrayToSort, left, j);
            return arrayToSort;
        }


    }
}
