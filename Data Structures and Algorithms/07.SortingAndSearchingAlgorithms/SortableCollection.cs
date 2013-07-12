namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
                if (item.CompareTo(this.Items[i]) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool BinarySearch(T item)
        {
            if (this.Items.Count == 0)
            {
                return false;
            }

            bool found = false;

            int min = 0;
            int max = this.Items.Count;
            int mid = (min + max) / 2;

            while(found == false)
            {
                if (item.CompareTo(this.Items[mid]) == 0)
                {
                    found = true;
                }

                if (item.CompareTo(this.Items[mid]) > 0)
                {
                    min = mid;
                }
                else if (item.CompareTo(this.Items[mid]) < 0)
                {
                    max = mid;
                }
            }

            return found;
        }

        public void Shuffle()
        {
            Random randomNumber = new Random();
            T tmp;

            for (int i = 0; i < this.Items.Count; i++)
            {
                int randomPosition = randomNumber.Next(0, this.Items.Count);
                tmp = this.Items[i];

                this.Items[i] = this.Items[randomPosition];
                this.Items[randomPosition] = tmp;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
