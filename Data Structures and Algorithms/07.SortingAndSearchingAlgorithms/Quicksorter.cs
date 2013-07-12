﻿namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection.Count > 1)
            {
                List<T> middleElement = new List<T> { collection[collection.Count / 2] };
                List<T> smallerElements = new List<T>();
                List<T> largerElements = new List<T>();
                for (int i = 0; i < collection.Count; i++)
                {
                    if (i != collection.Count / 2)
                    {
                        if (collection[i].CompareTo(middleElement[0]) < 0)
                        {
                            smallerElements.Add(collection[i]);
                        }
                        else
                        {
                            largerElements.Add(collection[i]);
                        }
                    }
                }

                this.Sort(smallerElements);
                this.Sort(largerElements);

                List<T> concatElements = smallerElements.Concat(middleElement).Concat(largerElements).ToList();

                for (int i = 0; i < concatElements.Count; i++)
                {
                    collection[i] = concatElements[i];
                }
            }
        }
    }
}
