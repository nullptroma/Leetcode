namespace _589._N_ary_Tree_Preorder_Traversal;

public class Solution
{
    public IList<int> Preorder(Node root)
    {
        List<int> list = new List<int>();
        RecursiveTraversal(list, root);
        return list;
    }

    private void RecursiveTraversal(List<int> output, Node cur)
    {
        if (cur == null)
            return;
        output.Add(cur.val);
        if (cur.children == null)
            return;
        foreach (var child in cur.children)
            RecursiveTraversal(output, child);
    }
}
