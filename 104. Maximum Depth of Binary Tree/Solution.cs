namespace _104._Maximum_Depth_of_Binary_Tree;

public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        var res = Recursion(0, root);
        if (root != null)
            res++;
        return res;
    }

    private int Recursion(int count, TreeNode node)
    {
        if(node == null)
            return 0;
        var list = new List<int>();
        if (node.left != null)
            list.Add(Recursion(count + 1, node.left));
        if (node.right != null)
            list.Add(Recursion(count + 1, node.right));
        if (list.Count > 0)
            return list.Max();
        return count;
    }
}
