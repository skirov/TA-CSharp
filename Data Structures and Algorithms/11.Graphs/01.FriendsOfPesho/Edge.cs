using System;

internal class Edge
{
    internal Node Target { get; private set; }
    internal int Distance { get; private set; }

    internal Edge(Node target, int distance)
    {
        this.Target = target;
        this.Distance = distance;
    }
}

