namespace _144._Binary_Tree_Preorder_Traversal;

public class Solution
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        List<int> res = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        if (root != null)
            stack.Push(root);
        while (stack.Count > 0)
        {
            TreeNode cur = stack.Pop();
            if (cur.right != null)
                stack.Push(cur.right);
            if (cur.left != null)
                stack.Push(cur.left);
            res.Add(cur.val);
        }
        return res;
    }
}
