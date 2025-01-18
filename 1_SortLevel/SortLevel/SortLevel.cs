using System;
using System.Collections.Generic;
using System.Linq;

namespace SortSpace
{
    public static class SortLevel
    {
        public static void SelectionSortStep(int[] array, int i)
        {
            if (i >= array.Length)
                return;

            int minPosition = MinElementPosition(array, i);

            if (array[minPosition] < array[i])
                Swap(array, i, minPosition);
        }

        public static int MinElementPosition(int[] array, int i)
        {
            int minPosition = i;

            for (int current = i; current < array.Length; current++)
            {
                if (array[minPosition] > array[current])
                    minPosition = current;
            }

            return minPosition;
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


        public static bool BubbleSortStep(int[] array)
        {
            var flagExchange = true;

            var currentFirst = 0;
            int currentValue = array[currentFirst];
            int currentPosition = currentFirst;

            for (int currentSecond = currentFirst + 1; currentSecond < array.Length; currentSecond++)
            {
                if (currentValue > array[currentSecond])
                {
                    Swap(array, currentSecond, currentPosition);
                    currentPosition = currentSecond;
                    flagExchange = false;
                }
            }

            return flagExchange;
        }
    }
}