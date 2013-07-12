using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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


public class Graph
{
    internal IDictionary<string, Node> Nodes { get; private set; }

    public Graph()
    {
        Nodes = new Dictionary<string, Node>();
    }

    public void AddNode(string name)
    {
        var node = new Node(name);
        Nodes.Add(name, node);
    }

    public void AddConnection(string fromNode, string toNode, int distance, bool twoWay)
    {
        Nodes[fromNode].AddConnection(Nodes[toNode], distance, twoWay);
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        foreach (var node in this.Nodes)
        {
            result.Append(node.Key + " -> ");

            foreach (var conection in node.Value.Connections)
            {
                result.Append(conection.Target + "-" + conection.Distance + " ");
            }

            result.AppendLine();
        }

        return result.ToString();
    }
}


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

class PriorityQueue<T>
    where T : IComparable<T>
{
    private readonly List<T> elements = new List<T>();

    public int Count
    {
        get { return this.elements.Count; }
    }

    public void Enqueue(T value)
    {
        this.elements.Add(value);

        for (int i = this.Count - 1; this.HasParent(i); i = this.ParentIndex(i))
        {
            if (this.elements[this.ParentIndex(i)].CompareTo(this.elements[i]) > 0)
                this.Swap(i, this.ParentIndex(i));

            else break;
        }
    }

    public T Dequeue()
    {
        var result = this.Peek();

        this.elements[0] = this.elements[this.Count - 1];
        this.elements.RemoveAt(this.Count - 1);

        for (int i = 0, smallerChild; this.HasLeftChild(i); i = smallerChild)
        {
            smallerChild = this.LeftIndex(i);

            if (this.HasRightChild(i) && this.elements[this.LeftIndex(i)].CompareTo(this.elements[this.RightIndex(i)]) > 0)
                smallerChild = this.RightIndex(i);

            if (this.elements[i].CompareTo(this.elements[smallerChild]) > 0)
                this.Swap(i, smallerChild);

            else break;
        }

        return result;
    }

    private bool HasParent(int i)
    {
        return i > 0;
    }

    private int ParentIndex(int i)
    {
        return (i - 1) / 2;
    }

    private int LeftIndex(int i)
    {
        return (i * 2) + 1;
    }

    private int RightIndex(int i)
    {
        return (i * 2) + 2;
    }

    private bool HasLeftChild(int i)
    {
        return this.LeftIndex(i) < this.Count;
    }

    private bool HasRightChild(int i)
    {
        return this.RightIndex(i) < this.Count;
    }

    private void Swap(int i, int j)
    {
        T prev = this.elements[i];
        this.elements[i] = this.elements[j];
        this.elements[j] = prev;
    }

    public T Peek()
    {
        return this.elements[0];
    }

    public void Clear()
    {
        this.elements.Clear();
    }

    public override string ToString()
    {
        var result = new List<IEnumerable<int>>();

        var currentQueue = new Queue<int>();
        currentQueue.Enqueue(0);

        while (currentQueue.Count != 0)
        {
            var nextQueue = new Queue<int>();

            foreach (var currentNode in currentQueue)
            {
                if (this.HasLeftChild(currentNode))
                    nextQueue.Enqueue(this.LeftIndex(currentNode));

                if (this.HasRightChild(currentNode))
                    nextQueue.Enqueue(this.RightIndex(currentNode));
            }

            result.Add(currentQueue);
            currentQueue = nextQueue;
        }

        return string.Join(Environment.NewLine,
            result.Select((list, row) =>
                string.Join(" ", list.Select(i => this.elements[i]))
            )
        );
    }
}

class Program
{
    static int Dijkstra(IDictionary<string, Node> graph, string hospital)
    {
        foreach (var point in graph)
        {
            point.Value.DijkstraDistance = int.MaxValue;
        }

        graph[hospital].DijkstraDistance = 0;

        PriorityQueue<Node> nodes = new PriorityQueue<Node>();

        nodes.Enqueue(graph[hospital]);

        while (nodes.Count > 0)
        {
            Node currentNode = nodes.Dequeue();

            if (currentNode.DijkstraDistance == int.MaxValue)
            {
                break;
            }

            foreach (var item in currentNode.Connections)
            {
                int potentialDistance = currentNode.DijkstraDistance + item.Distance;

                if (potentialDistance < item.Target.DijkstraDistance)
                {
                    item.Target.DijkstraDistance = potentialDistance;
                    nodes.Enqueue(item.Target);
                }
            }
        }

        int distance = 0;

        foreach (var item in graph)
        {
            if (!item.Value.IsHospital && item.Value.DijkstraDistance != int.MaxValue)
            {
                distance += item.Value.DijkstraDistance;
            }
        }

        return distance;
    }

    static void Main()
    {
        Graph graph = new Graph();

        string[] townInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string numberOfPoints = townInfo[0];

        int numberOfRoads = int.Parse(townInfo[1]);

        HashSet<string> hospitals =
            new HashSet<string>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

        for (int i = 0; i < numberOfRoads; i++)
        {
            string[] roadsInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string from = roadsInfo[0];
            string to = roadsInfo[1];
            int distance = int.Parse(roadsInfo[2]);

            if (!graph.Nodes.ContainsKey(from))
            {
                graph.AddNode(from);
            }

            if (!graph.Nodes.ContainsKey(to))
            {
                graph.AddNode(to);
            }

            graph.AddConnection(from, to, distance, true);

            if (hospitals.Contains(from))
            {
                graph.Nodes[from].IsHospital = true;
            }

            if (hospitals.Contains(to))
            {
                graph.Nodes[to].IsHospital = true;
            }
        }

        //Console.WriteLine(graph);

        int minDistance = int.MaxValue;

        foreach (var hospital in hospitals)
        {
            int currentDistance = Dijkstra(graph.Nodes, hospital);

            if (currentDistance < minDistance)
            {
                minDistance = currentDistance;
            }
        }

        Console.WriteLine(minDistance);
    }
}

