using System;
using System.Collections.Generic;
using System.Text;

public class Stack<T> : IEnumerable<T>
{
    private T[] stackArray;
    private int size;

    public Stack()
    {
        stackArray = new T[10];
        size = 0;
    }

    public int Size
    {
        get
        {
            return this.size;
        }
    }

    public void Push(T value)
    {
        if (this.Size == stackArray.Length)
        {
            T[] newStack = new T[stackArray.Length * 2];
            Array.Copy(stackArray, newStack, stackArray.Length);
            this.stackArray = newStack;
        }

        stackArray[this.Size] = value;
        size++;
    }

    public T Pop()
    {
        if (this.Size == 0)
        {
            throw new InvalidOperationException("The stack has no elements.");
        }

        T lastElement = stackArray[this.Size - 1];
        stackArray[this.Size - 1] = default(T);
        this.size--;

        return lastElement;
    }

    public T Peek()
    {
        if (this.Size == 0)
        {
            throw new InvalidOperationException("The stack has no elements.");
        }

        T lastElement = stackArray[this.Size - 1];

        return lastElement;
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in stackArray)
        {
            if ((dynamic)item == default(T))
            {
                break;
            }

            yield return item;
        }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}