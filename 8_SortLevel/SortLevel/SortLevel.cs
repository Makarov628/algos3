using System;
using System.Collections.Generic;
using System.Linq;

namespace SortSpace
{
    public static class SortLevel
    {
        public static List<int> MergeSort(List<int> input)
        {
            if (input.Count <= 1)
            {
                return input;
            }

            int middle = input.Count / 2;

            List<int> sublist1 = MergeSort(input.GetRange(0, middle));
            List<int> sublist2 = MergeSort(input.GetRange(middle, input.Count - middle));

            List<int> result = new List<int>();

            while (sublist1.Any() && sublist2.Any())
            {
                if (sublist1.First() < sublist2.First())
                {
                    result.Add(sublist1.First());
                    sublist1.RemoveAt(0);
                    continue;
                }

                if (sublist1.First() >= sublist2.First())
                {
                    result.Add(sublist2.First());
                    sublist2.RemoveAt(0);
                    continue;
                }
            }

            result.AddRange(sublist1);
            result.AddRange(sublist2);

            return result;
        }
    }
}