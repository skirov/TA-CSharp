using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

class FiendsInNeed
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

            //if (currentNode.DijkstraDistance == int.MaxValue)
            //{
            //    break;
            //}

            //all connections of the hospital
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

