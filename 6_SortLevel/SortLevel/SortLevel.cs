using System;
using System.Collections.Generic;
using System.Linq;

namespace SortSpace
{
    public static class SortLevel
    {
        public static void QuickSortTailOptimization(int[] array, int left, int right)
        {
            int start = left;
            int end = right;

            if (left < right)
            {
                int division = ArrayChunk(array, left, right);
                if (left < end)
                {
                    QuickSortTailOptimization(array, start, division - 1);
                }

                if (right > start)
                {
                    QuickSortTailOptimization(array, division + 1, end);
                }
            }
        }

        private static int ArrayChunk(int[] M, int left, int right)
        {
            if (M.Length == 0)
                return -1;

            int nIndex = (right - left + 1) / 2 + left;
            int N = M[nIndex];
            int i1 = left;
            int i2 = right;

            while (true)
            {
                while (M[i1] < N)
                    i1++;

                while (M[i2] > N)
                    i2--;

                if (i1 == i2 - 1 && M[i1] > M[i2])
                {
                    Swap(M, i1, i2);
                    nIndex = (right - left + 1) / 2 + left;
                    N = M[nIndex];
                    i1 = left;
                    i2 = right;
                    continue;
                }
                if (i1 == i2 || (i1 == i2 - 1 && M[i1] < M[i2]))
                {
                    return nIndex;
                }

                nIndex = nIndex == i1
                    ? i2
                    : nIndex == i2
                        ? i1
                        : nIndex;

                Swap(M, i1, i2);
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