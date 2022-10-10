namespace _98._Validate_Binary_Search_Tree;

public class Solution
{
    public bool IsValidBST(TreeNode root)
    {
        return Rec(root, null, null);
    }

    private bool Rec(TreeNode node, int? lessThan, int? moreThan)
    {
        if((lessThan != null && node.val >= lessThan) || (moreThan != null && node.val <= moreThan))
            return false;
        bool res = true;
        if(node.left != null)
            res&=Rec(node.left, node.val, moreThan);
        if(node.right != null)
            res &=Rec(node.right, lessThan, node.val);
        return res;
    }
}
