using System;
using System.Collections.Generic;
class CableTV
{
    static PriorityQueue<Edge> queue = new PriorityQueue<Edge>();
    static HashSet<string> usedNodes = new HashSet<string>();

    static List<Edge> Prim(Graph neighborhood)
    {
        List<Edge> minSpanningTree = new List<Edge>();
        int edgesCount = 0;

        //add all edges in the queue

        foreach (var item in neighborhood.Nodes["HouseA"].Connections)
        {
            queue.Enqueue(item);
        }

        usedNodes.Add(queue.Peek().StartNode);

        while (queue.Count > 0)
        {
            Edge curentEdge = queue.Dequeue();

            if (!usedNodes.Contains(curentEdge.Target.Name))
            {
                usedNodes.Add(curentEdge.Target.Name);
                minSpanningTree.Add(curentEdge);
                AddChildNodesToQueue(curentEdge, neighborhood.Nodes[curentEdge.Target.Name].Connections, minSpanningTree);
            }
        }

        return minSpanningTree;
    }

    private static void AddChildNodesToQueue(Edge edge, IList<Edge> edges, List<Edge> mpd)
    {
        for (int i = 0; i < edges.Count; i++)
        {
            if (!mpd.Contains(edges[i]))
            {
                if (edge.Target.Name == edges[i].StartNode && !usedNodes.Contains(edges[i].Target.Name))
                {
                    queue.Enqueue(edges[i]);
                }
            }
        }
    }

    static void Main()
    {
        Graph neighborhood = new Graph();

        neighborhood.AddNode("HouseA");
        neighborhood.AddNode("HouseB");
        neighborhood.AddNode("HouseC");
        neighborhood.AddNode("HouseD");
        neighborhood.AddNode("HouseE");
        neighborhood.AddNode("HouseF");

        //neighborhood.AddConnection("HouseA", "HouseB", 13, true);
        //neighborhood.AddConnection("HouseB", "HouseC", 1,  true);
        //neighborhood.AddConnection("HouseC", "HouseD", 1,  true);
        //neighborhood.AddConnection("HouseD", "HouseE", 2,  true);
        //neighborhood.AddConnection("HouseE", "HouseF", 3,  true);
        //neighborhood.AddConnection("HouseA", "HouseE", 8,  true);

        neighborhood.AddConnection("HouseA", "HouseB", 4, true);
        neighborhood.AddConnection("HouseB", "HouseD", 2, true);
        neighborhood.AddConnection("HouseD", "HouseC", 20, true);
        neighborhood.AddConnection("HouseA", "HouseD", 9, true);
        neighborhood.AddConnection("HouseA", "HouseC", 5, true);
        neighborhood.AddConnection("HouseC", "HouseE", 7, true);
        neighborhood.AddConnection("HouseD", "HouseE", 8, true);
        neighborhood.AddConnection("HouseE", "HouseF", 12, true);

        List<Edge> minTree = Prim(neighborhood);

        Console.WriteLine(neighborhood);

        foreach (var item in minTree)
        {
            Console.WriteLine("{0} -> {1}", item.Target, item.Distance);
        }
    }
}

