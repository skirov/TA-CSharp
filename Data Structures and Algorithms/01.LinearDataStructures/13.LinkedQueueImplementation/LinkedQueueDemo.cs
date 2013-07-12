using System;
public class Program
{
     public static void Main()
    {
        LinkedQueue<int> list = new LinkedQueue<int>();

        list.Enqueue(5);
        list.Enqueue(6);
        list.Enqueue(7);
        list.Enqueue(8);

        Console.WriteLine(list.Dequeue());
        Console.WriteLine(list.Dequeue());

        Console.WriteLine("List count: {0}", list.Count);
    }
}

