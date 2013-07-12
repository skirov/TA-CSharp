using System;

public class Program
{
    static void Main()
    {
        PriorityQueue<int> myPriorityQueue = new PriorityQueue<int>();
        myPriorityQueue.Enqueue(7);
        myPriorityQueue.Enqueue(17);
        myPriorityQueue.Enqueue(3);
        myPriorityQueue.Enqueue(90);

        myPriorityQueue.Dequeue();

        myPriorityQueue.Enqueue(91);
        myPriorityQueue.Enqueue(53);

        Console.WriteLine(myPriorityQueue.Dequeue());

        myPriorityQueue.Print();
    }
}

