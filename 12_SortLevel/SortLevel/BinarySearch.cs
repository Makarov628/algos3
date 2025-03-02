using System;
using System.Collections.Generic;
using System.Linq;

namespace SortSpace
{
    public class BinarySearch
    {
        public int Left;
        public int Right;
        public int[] Array;
        private int found;

        public BinarySearch(int[] arr)
        {
            Left = 0;
            Right = arr.Length - 1;
            Array = arr;
        }

        public void Step(int N)
        {
            if (found != 0)
            {
                return;
            }

            int central = (Right + Left) / 2;

            if (N == Array[central])
            {
                found = 1;
                return;
            }
            if (N < Array[central])
            {
                Right = central - 1;
                found = 0;
            }
            if (N > Array[central])
            {
                Left = central + 1;
                found = 0;
            }
            if (Right < Left)
            {
                found = -1;
                return;
            }

            if (Right - Left <= 1)
            {
                found = Array[Right] == N || Array[Left] == N ? 1 : -1;
                return;
            }
        }

        public int GetResult()
        {
            return found;
        }

        public static bool GallopingSearch(int[] array, int N)
        {
            if (array.Length == 0)
                return false;

            int i = 1;
            int index = 0;

            while (array[index] <= N && index < array.Length - 1)
            {
                if (array[index] == N)
                    return true;

                if (array[index] > N)
                    break;

                i++;
                index = Convert.ToInt32(Math.Pow(2, i) - 2);

                if (index >= array.Length - 1)
                    index = array.Length - 1;
            }

            BinarySearch bs = new BinarySearch(array);
            bs.Left = Convert.ToInt32(Math.Pow(2, i - 1)) - 1;
            bs.Right = index;

            while (bs.GetResult() == 0)
                bs.Step(N);

            return bs.GetResult() == 1;
        }
    }
}