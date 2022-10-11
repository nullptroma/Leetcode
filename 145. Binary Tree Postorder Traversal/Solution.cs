namespace _145._Binary_Tree_Postorder_Traversal;

public class Solution
{
    public IList<int> PostorderTraversal(TreeNode root)
    {
        var result = new List<int>();
        if (root == null) return result;
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        while (stack.Any())
        {
            var cur = stack.Pop();
            result.Add(cur.val);
            if (cur.left != null)
                stack.Push(cur.left);
            if (cur.right != null)
                stack.Push(cur.right);
        }
        result.Reverse();

        return result;
    }
}