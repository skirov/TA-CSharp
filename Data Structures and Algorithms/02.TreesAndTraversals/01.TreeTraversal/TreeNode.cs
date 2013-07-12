using System;
using System.Collections.Generic;

public class TreeNode
{
    public int Value { get; set; }
    public List<TreeNode> Children { get; set; }
    public bool HasParent { get; set; }

    public TreeNode()
    {
        this.Children = new List<TreeNode>();
    }

    public TreeNode(int value) : this()
    {
        this.Value = value;
    }
}

