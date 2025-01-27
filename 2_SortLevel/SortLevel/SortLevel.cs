using System;
using System.Collections.Generic;
using System.Linq;

namespace SortSpace
{
    public static class SortLevel
    {
        public static void InsertionSortStep(int[] array, int step, int i)
        {
            if ((step < 0) || (i < 0))
            {
                return;
            }

            for (int indexFirst = i; indexFirst < array.Length; indexFirst += step)
            {
                int currentValue = array[indexFirst];
                int currentPosition = indexFirst;

                for (int indexSecond = i; indexSecond < indexFirst; indexSecond += step)
                {
                    if (currentValue < array[indexSecond])
                    {
                        currentValue = array[indexSecond];
                        Swap(array, indexSecond, currentPosition);
                    }
                }
            }
        }

        public static bool Swap(int[] array, int oldPosition, int newPosition)
        {
            if (oldPosition == newPosition)
                return true;

            int oldElement = array[oldPosition];
            array[oldPosition] = array[newPosition];
            array[newPosition] = oldElement;

            return true;
        }
    }
}