using System;
using System.Collections.Generic;
using System.Text;

namespace WhoSortedThisOut
{
    public class ArrayHelper
    {
        public int Maximum(int[] numbers)
        {
            // TODO - Find the index of the largest number in the array "numbers"
            // TODO - If the array is empty, return -1
            // The array "numbers" does not contain duplicate values

            if (numbers.Length == 0)
            {
                return -1;
            }

            int iMax = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[iMax])
                {
                    iMax = i;
                }
            }

            return iMax;
        }

        public bool IsSortedAscending(int[] numbers)
        {
            // TODO - Check if "numbers" is sorted ascending (small to large)
            // TODO - If "numbers" is empty return false
            // The array "numbers" does not contain duplicate values

            if (numbers.Length == 0) return false;
            if (numbers.Length == 1) return true;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    return false;
                }
            }

            // If we get here its ok
            return true;
        }
    }
}
