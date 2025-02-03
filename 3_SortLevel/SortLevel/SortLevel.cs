using System;
using System.Collections.Generic;
using System.Linq;

namespace SortSpace
{
    public static class SortLevel
    {
        public static void ShellSort(int[] array)
        {
            var sequence = KnuthSequence(array.Length);

            foreach (var step in sequence)
            {
                for (int i = 0; i < step; i++)
                {
                    InsertionSortStep(array, step, i);
                }
            }
        }

        public static List<int> KnuthSequence(int arraySize)
        {
            List<int> list = new List<int>();

            for (int knuthElement = KnuthNextStep(1, arraySize); knuthElement >= 1; knuthElement = CalculateKnuthPrestep(knuthElement))
                list.Add(knuthElement);

            return list;
        }

        public static int CalculateKnuthPrestep(int t)
        {
            return (t - 1) / 3;
        }

        public static int CalculateKnuthStep(int t)
        {
            return 3 * t + 1;
        }

        public static int KnuthNextStep(int t, int s)
        {
            if (CalculateKnuthStep(t) > s) return t;
            t = CalculateKnuthStep(t);
            return KnuthNextStep(t, s);
        }

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