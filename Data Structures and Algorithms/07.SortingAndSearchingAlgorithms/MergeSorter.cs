namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection.Count <= 1)
            {
                return;
            }
            List<T> left = new List<T>();
            List<T> right = new List<T>();
            int middle = collection.Count / 2;

            for (int i = 0; i < middle; i++)
            {
                left.Add(collection[i]);
            }

            for (int i = middle; i < collection.Count; i++)
            {
                right.Add(collection[i]);
            }

            this.Sort(left);
            this.Sort(right);

            List<T> merged = Merge(left, right);

            for (int i = 0; i < merged.Count; i++)
            {
                collection[i] = merged[i];
            }
        }

        private List<T> Merge(List<T> left, List<T> right)
        {
            List<T> result = new List<T>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left[0].CompareTo(right[0]) <= 0)
                    {
                        result.Add(left[0]);
                        left.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(right[0]);
                        right.RemoveAt(0);
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else if (right.Count > 0)
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            return result;
        }
    }
}
