using System;

public class QueueItem<T>
{
    private T value;
    private QueueItem<T> prevItem;

    public QueueItem(T value)
    {
        this.Value = value;
    }

    public T Value
    {
        get
        {
            return this.value;
        }
        set
        {
            this.value = value;
        }
    }

    public QueueItem<T> PrevItem
    {
        get
        {
            return this.prevItem;
        }
        set
        {
            this.prevItem = value;
        }
    }
}

