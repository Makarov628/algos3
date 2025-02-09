using System;
using System.Collections.Generic;
using System.Linq;

namespace SortSpace
{
    public static class SortLevel
    {
        public static int ArrayChunk(int[] M)
        {
            if (M.Length == 0)
                return -1;

            int nIndex = M.Length / 2;
            int N = M[nIndex];
            int i1 = 0;
            int i2 = M.Length - 1;

            while (true)
            {
                while (M[i1] < N)
                    i1++;

                while (M[i2] > N)
                    i2--;

                if (i1 == i2 - 1 && M[i1] > M[i2])
                {
                    Swap(M, i1, i2);

                    nIndex = M.Length / 2;
                    N = M[nIndex];
                    i1 = 0;
                    i2 = M.Length - 1;

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