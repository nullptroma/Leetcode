namespace _235._Lowest_Common_Ancestor_of_a_Binary_Search_Tree;

public class Solution
{
    public TreeNode? LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        int min = Math.Min(p.val, q.val);
        int max = Math.Max(p.val, q.val);
        while(true)
        {
            if (root == null)
                return null;
            else if (min <= root.val && max>=root.val)
                return root;
            else if (root.val >= p.val)
                root = root.left!;
            else
                root = root.right!;
        }
    }
}