using System;
using System.Collections.Generic;

public class LinkedQueue<T>
{
    private QueueItem<T> previousQueueElement;
    private QueueItem<T> currentQueueElement;

    private int count;

    public int Count
    {
        get
        {
            return this.count;
        }
    }

    public void Enqueue(T data)
    {
        if (currentQueueElement == null)
        {
            previousQueueElement = new QueueItem<T>(data);
            currentQueueElement = previousQueueElement;
        }
        else
        {
            previousQueueElement.PrevItem = new QueueItem<T>(data);
            previousQueueElement = previousQueueElement.PrevItem;
        }

        count++;
    }

    public T Dequeue()
    {
        if (currentQueueElement == null)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        T valueToReturn = currentQueueElement.Value;

        currentQueueElement = currentQueueElement.PrevItem;

        count--;

        return valueToReturn;
    }

}

