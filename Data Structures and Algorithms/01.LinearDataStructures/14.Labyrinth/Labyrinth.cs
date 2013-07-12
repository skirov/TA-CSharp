using System;
using System.Collections.Generic;

public class Labyrinth
{
    static int[,] directions = new int[,]
    { 
        { 1, 0 },
        { 0, 1 }, 
        { -1, 0 }, 
        { 0, -1 } 
    };

    private static void BFS(string[,] labirynth)
    {
        Queue<Tuple<Point, int>> queue = new Queue<Tuple<Point, int>>();
        queue.Enqueue(new Tuple<Point, int>(labirynth.GetStartingPoint(), 1));

        while (queue.Count > 0)
        {
            Tuple<Point, int> currentNode = queue.Dequeue();

            for (int i = 0; i < directions.GetLength(0); i++)
            {
                int newRow = currentNode.Item1.Row + directions[i, 0];
                int newCol = currentNode.Item1.Col + directions[i, 1];

                Point step = new Point(newRow, newCol);

                if (labirynth.InBouds(step.Row, step.Col))
                {
                    if (labirynth[step.Row, step.Col] == "0")
                    {
                        labirynth[step.Row, step.Col] = currentNode.Item2.ToString();
                        queue.Enqueue(new Tuple<Point, int>(step, currentNode.Item2 + 1));
                    }
                }
            }
        }
    }

    public static void Main()
    {
        string[,] labirynth = 
        {
            { "0", "0", "0", "X", "0", "X" },
            { "0", "X", "0", "X", "0", "X" },
            { "0", "*", "X", "0", "X", "0" },
            { "0", "X", "0", "0", "0", "0" },
            { "0", "0", "0", "X", "X", "0" },
            { "0", "0", "0", "X", "0", "X" }
        };

        labirynth.PrintLabirynth();

        BFS(labirynth);

        labirynth.MarkUnreachableSpaces();

        labirynth.PrintLabirynth();
    }
}

