using System;
using System.Linq;


public class LinkedListDemo
{
    public static void Main()
    {
        LinkedList<int> list = new LinkedList<int>();

        list.Add(new ListItem<int>(6));
        list.Add(new ListItem<int>(5));
        list.Add(new ListItem<int>(7));
        list.Add(new ListItem<int>(4));

        list.PrintAll();
    }
}

