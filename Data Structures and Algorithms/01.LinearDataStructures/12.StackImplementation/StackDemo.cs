using System;

public class StackDemo
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(5);
        stack.Push(6);
        stack.Push(7);

        stack.Pop();

        Console.WriteLine(stack.Peek());

        stack.Push(7);
        stack.Push(8);
        stack.Push(9);
        
        foreach (var item in stack)
        {
            Console.Write("{0} ", item);
        }
    }
}

