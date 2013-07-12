using System;

public class InvalidRangeException<T> : ApplicationException
    where T : IComparable
{
    private T startRange;
    private T endRange;

    public InvalidRangeException()
        : base()
    {

    }

    public InvalidRangeException(T startRange, T endRange, string msg)
        : base(msg)
    {
        this.startRange = startRange;
        this.endRange = endRange;
    }

    public T StartRange
    {
        get
        {
            return this.startRange;
        }
    }

    public T EndRange
    {
        get
        {
            return this.endRange;
        }
    }
}
