using System;
using System.Linq;

public class LinkedList<T>
{
    private ListItem<T> firstElement;
    private ListItem<T> currentElement;

    public void Add(ListItem<T> data)
    {
        if (firstElement == null)
        {
            firstElement = data;
            currentElement = firstElement;
        }
        else
        {
            currentElement.NextItem = data;
            currentElement = currentElement.NextItem;
        }
    }

    public void PrintAll()
    {
        while (firstElement != null)
        {
            Console.WriteLine(firstElement.Value);
            firstElement = firstElement.NextItem;
        }
    }
}
