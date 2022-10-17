namespace _226._Invert_Binary_Tree;

public class Solution
{
    public TreeNode? InvertTree(TreeNode root)
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        if (root != null)
            stack.Push(root);
        while (stack.Count > 0)
        {
            TreeNode cur = stack.Pop();
            TreeNode? buf = cur.left;
            cur.left = cur.right;
            cur.right = buf;
            if (cur.right != null)
                stack.Push(cur.right);
            if (cur.left != null)
                stack.Push(cur.left);
        }
        return root;
    }
}