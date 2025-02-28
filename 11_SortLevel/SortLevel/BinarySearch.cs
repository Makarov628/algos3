using System;
using System.Collections.Generic;
using System.Linq;

namespace SortSpace
{
    public class BinarySearch
    {
        int Left;
        int Right;
        private int[] array;
        private int found;

        public BinarySearch(int[] arr)
        {
            Left = 0;
            Right = arr.Length - 1;
            array = arr;
        }

        public void Step(int N)
        {
            int central = (Right + Left) / 2;

            if (N == array[central])
            {
                found = 1;
                return;
            }
            if (N < array[central])
            {
                Right = central - 1;
                found = 0;
            }
            if (N > array[central])
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
                found = array[Right] == N || array[Left] == N ? 1 : -1;
                return;
            }
        }

        public int GetResult()
        {
            return found;
        }
    }
}