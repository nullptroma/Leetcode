namespace _116._Populating_Next_Right_Pointers_in_Each_Node;

public class Solution
{
    public Node? Connect(Node? root)
    {
        if (root == null)
            return null;
        List<Node> curLevel = new List<Node>() { root };
        List<Node> nextLevel = new List<Node>();
        while (curLevel.Count > 0)
        {
            for (int i = 0; i < curLevel.Count - 1; i++)
                curLevel[i].next = curLevel[i + 1];
            nextLevel.Clear();
            foreach (var n in curLevel)
            {
                if (n == null)
                    continue;
                if (n.left != null)
                    nextLevel.Add(n.left);
                if (n.right != null)
                    nextLevel.Add(n.right);
            }
            List<Node> buf = curLevel;
            curLevel = nextLevel;
            nextLevel = buf;
        }
        return root;
    }
}