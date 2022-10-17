namespace _112._Path_Sum;

public class Solution
{
    public bool HasPathSum(TreeNode root, int targetSum) 
        => root != null ? Recursion(root, root.val, targetSum) : false;

    private bool Recursion(TreeNode? node, int curSum, int targetSum)
    {
        if (curSum == targetSum && node != null && node.left == null && node.right == null)
            return true;
        if (node == null)
            return false;
        bool res = false;
        if(node.left != null)
            res |= Recursion(node.left, curSum + node.left.val, targetSum);
        if (node.right != null)
            res |= Recursion(node.right, curSum + node.right.val, targetSum);
        return res;
    }
}