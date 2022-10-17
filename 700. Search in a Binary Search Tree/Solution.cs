namespace _700._Search_in_a_Binary_Search_Tree;

public class Solution
{
    public TreeNode? SearchBST(TreeNode? root, int val)
    {
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
            if(cur.val == val)
                return cur;
        }
        return null;
    }
}