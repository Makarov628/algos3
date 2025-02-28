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
    }
}