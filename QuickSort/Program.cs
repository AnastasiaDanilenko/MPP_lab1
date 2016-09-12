using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {

        public static int[] GenerateArray(int amountParameters)
        {
            int[] arrayToSort = new int[amountParameters];
            Random randomGenerator = new Random();
            for (int i = 0; i < amountParameters; i++)
                arrayToSort[i] = randomGenerator.Next(-1000,1000);
            return arrayToSort;
        }

        public static void StartWorking(int amountParameters)
        {
            int[] arrayToSort = GenerateArray(amountParameters);
            QuickSortClass quicksort = new QuickSortClass(amountParameters);
            quicksort.StartSorting(arrayToSort);
        }

        public static void TryToRecognizeNumber(string someNumber)
        {
            try
            {
                StartWorking(int.Parse(someNumber));
            }
            catch (FormatException e)
            {
                Console.WriteLine("Input data was not a number.");
            }
        }

        static void Main()
        {
            try
            {
                TryToRecognizeNumber(Console.ReadLine());
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("An error occured while reading data. Please, check.");
            }
           
        }
    }
}
