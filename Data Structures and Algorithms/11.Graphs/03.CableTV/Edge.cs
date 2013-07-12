using System;

internal class Edge : IComparable<Edge>
{
    internal Node Target { get; private set; }
    internal int Distance { get; private set; }
    internal string StartNode { get; private set; }

    internal Edge(Node target, int distance, string startNode)
    {
        this.Target = target;
        this.Distance = distance;
        this.StartNode = startNode;
    }

    public int CompareTo(Edge other)
    {
        return this.Distance.CompareTo(other.Distance);
    }
}

