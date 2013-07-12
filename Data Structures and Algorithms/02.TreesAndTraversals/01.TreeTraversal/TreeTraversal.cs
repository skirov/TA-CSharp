using System;
using System.Collections.Generic;

public class TreeTraversal
{
    static int longestPathCount = 0;
    static int longestPathMaxCount = 0;

    private static int FindRoot(List<TreeNode> tree)
    {
        for (int i = 0; i < tree.Count; i++)
        {
            if (tree[i].HasParent == false)
            {
                return tree[i].Value;
            }
        }

        throw new ArgumentException("FindRoot method has an invalid argument.");
    }

    private static List<int> FindLeafs(List<TreeNode> tree)
    {
        List<int> leafs = new List<int>();

        for (int i = 0; i < tree.Count; i++)
        {
            if (tree[i].Children.Count == 0)
            {
                leafs.Add(tree[i].Value);
            }
        }

        return leafs;
    }

    private static List<int> FindMiddleNodes(List<TreeNode> tree)
    {
        List<int> middleNodes = new List<int>();

        for (int i = 0; i < tree.Count; i++)
        {
            if (tree[i].Children.Count > 0 && tree[i].HasParent == true)
            {
                middleNodes.Add(tree[i].Value);
            }
        }

        return middleNodes;
    }

    private static void FindLongestPath(TreeNode Node)
    {
        if (Node.Children.Count == 0)
        {
            if (longestPathCount > longestPathMaxCount)
            {
                longestPathMaxCount = longestPathCount;
            }
        }
        else
        {
            longestPathCount++;
        }

        foreach (var child in Node.Children)
        {
            FindLongestPath(child);
        }
    }

    public static void Main()
    {
        int numberOfNodes = int.Parse(Console.ReadLine());

        List<TreeNode> tree = new List<TreeNode>();

        for (int i = 0; i < numberOfNodes; i++)
        {
            tree.Add(new TreeNode(i));
        }

        for (int i = 0; i < numberOfNodes-1; i++)
        {
            string[] parentAndChild = Console.ReadLine().Split(' ');

            int parent = int.Parse(parentAndChild[0]);
            int child = int.Parse(parentAndChild[1]);

            tree[parent].Children.Add(tree[child]);
            tree[child].HasParent = true;
        }

        //Find root
        int valueOfRoot = FindRoot(tree);
        Console.WriteLine("The root of the tree is -> {0}", valueOfRoot);

        //Find leafs
        List<int> leafs = FindLeafs(tree);

        Console.Write("The leafs of the tree are -> ");
        foreach (var leaf in leafs)
        {
            Console.Write("{0} ", leaf);
        }
        Console.WriteLine();

        //Find all middle nodes
        List<int> middleNodes = FindMiddleNodes(tree);

        Console.Write("The middle elements of the tree are -> ");
        foreach (var middleNode in middleNodes)
        {
            Console.Write("{0} ", middleNode);
        }
        Console.WriteLine();

        //Find longest path
        FindLongestPath(tree[valueOfRoot]);
        Console.WriteLine("The count of steps for the longest path are -> {0}", longestPathMaxCount);
    }
}