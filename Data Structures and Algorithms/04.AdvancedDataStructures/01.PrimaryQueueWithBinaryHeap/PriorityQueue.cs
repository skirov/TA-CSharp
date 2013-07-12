using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PriorityQueue<T> where T : IComparable
{
    private int initialSize = 16;
    private T[] binaryHeap;

    public int Count { get; private set; }

    public PriorityQueue()
    {
        this.binaryHeap = new T[this.initialSize];
    }

    public PriorityQueue(int size)
    {
        this.binaryHeap = new T[size];
        this.initialSize = size;
    }

    public void Enqueue(T value)
    {
        if (this.Count >= this.binaryHeap.Length - 1)
        {
            Resize();
        }

        this.binaryHeap[this.Count] = value;
        this.MoveUp();
        this.Count++;
    }

    public T Dequeue()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("There are no elements in the queue");
        }

        T itemToDequeue = this.binaryHeap[0];
        this.Count--;

        this.binaryHeap[0] = this.binaryHeap[this.Count];
        MaxHeapify();

        this.binaryHeap[this.Count] = (dynamic)0;
        return itemToDequeue;
    }

    public void Print()
    {
        for (int i = 0; i < this.Count; i++)
        {
            Console.Write("{0} ", binaryHeap[i]);
        }
        Console.WriteLine();
    }

    private void Resize()
    {
        T[] newArray = new T[this.Count * 2];

        for (int i = 0; i < binaryHeap.Length; i++)
        {
            newArray[i] = binaryHeap[i];
        }

        this.binaryHeap = newArray;
    }

    private void MoveUp()
    {
        int lastEnqueuedElementPosition = this.Count;
        int lastElementParentPosition = (this.Count - 1) / 2;

        while (this.binaryHeap[lastEnqueuedElementPosition].CompareTo(this.binaryHeap[lastElementParentPosition]) == 1)
        {
            Swap(lastEnqueuedElementPosition, lastElementParentPosition);

            lastEnqueuedElementPosition = lastElementParentPosition;
            lastElementParentPosition = (lastElementParentPosition - 1) / 2;
        }
    }

    private void Swap(int childPosition, int parentPosition)
    {
        T childElement = this.binaryHeap[childPosition];
        T parentElement = this.binaryHeap[parentPosition];
        
        T tmp = parentElement;

        this.binaryHeap[parentPosition] = childElement;
        this.binaryHeap[childPosition] = tmp;
    }

    private void MaxHeapify()
    {
        int elementToShiftDown = 0;
        int leftChild = (2 * elementToShiftDown) + 1;
        int rightChild = (2 * elementToShiftDown) + 2;

        while(this.binaryHeap[leftChild].CompareTo(this.binaryHeap[elementToShiftDown]) > 0 ||
              this.binaryHeap[rightChild].CompareTo(this.binaryHeap[elementToShiftDown]) > 0)
        {
            if (this.binaryHeap[leftChild].CompareTo(this.binaryHeap[elementToShiftDown]) > 0)
            {
                Swap(leftChild, elementToShiftDown);
                elementToShiftDown = leftChild;
            }
            else if (this.binaryHeap[rightChild].CompareTo(this.binaryHeap[elementToShiftDown]) > 0)
            {
                Swap(rightChild, elementToShiftDown);
                elementToShiftDown = rightChild;
            }
        }
    }
}
