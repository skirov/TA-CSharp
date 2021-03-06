﻿using System;
using System.Collections.Generic;

internal class Node : IComparable<Node>
{
    IList<Edge> _connections;

    internal string Name { get; private set; }

    public int DijkstraDistance { get; set; }

    public bool IsHospital { get; set; }

    internal IList<Edge> Connections
    {
        get { return _connections; }
    }

    internal Node(string name)
    {
        Name = name;
        _connections = new List<Edge>();
    }

    internal void AddConnection(Node targetNode, int distance, bool twoWay)
    {
        if (targetNode == null) throw new ArgumentNullException("targetNode");
        if (targetNode == this)
            throw new ArgumentException("Node may not connect to itself.");
        if (distance <= 0) throw new ArgumentException("Distance must be positive.");

        _connections.Add(new Edge(targetNode, distance));
        if (twoWay) targetNode.AddConnection(this, distance, false);
    }

    public override string ToString()
    {
        return this.Name;
    }

    public int CompareTo(Node other)
    {
        return this.DijkstraDistance.CompareTo(other.DijkstraDistance);
    }
}