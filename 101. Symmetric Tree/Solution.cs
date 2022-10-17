namespace _101._Symmetric_Tree;

public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        return Recursion(root.left, root.right);
    }

    private bool Recursion(TreeNode? left, TreeNode? right)
    {
        if ((left == null) != (right == null))
            return false;
        if (left == null || right == null)
            return true;
        if (left.val != right.val)
            return false;
        return Recursion(left.left, right.right) && Recursion(left.right, right.left);
    }
}