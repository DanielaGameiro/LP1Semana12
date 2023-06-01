using System;
using System.Collections.Generic;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T targetItem) where T : IComparable<T>
        {
            foreach (T item in items)
            {
                if (item.CompareTo(targetItem) < 0)
                {
                    yield return item;
                }
            }
        }
    }
}