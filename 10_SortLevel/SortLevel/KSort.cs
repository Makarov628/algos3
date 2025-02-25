using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SortSpace
{
    public class KSort
    {
        public string[] items;

        public KSort()
        {
            items = new string[800];
        }

        public int Index(string s)
        {
            if (!_indexRegex.IsMatch(s))
                return -1;

            return (s[0] - 97) * 100
                 + (s[1] - 48) * 10
                 + (s[2] - 48);
        }

        public bool Add(string s)
        {
            int index = Index(s);
            if (index == -1)
                return false;

            items[index] = s;
            return true;
        }

        private static Regex _indexRegex = new Regex(
            "^[a-h]\\d{2}$",
            RegexOptions.Compiled);
    }
}