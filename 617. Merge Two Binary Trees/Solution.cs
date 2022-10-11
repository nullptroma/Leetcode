namespace _617._Merge_Two_Binary_Trees;

public class Solution
{
    public TreeNode? MergeTrees(TreeNode root1, TreeNode root2)
    {
        if (root1 == null && root2 == null)
            return null;
        else if (root1 == null)
            return root2;
        else if (root2 == null)
            return root1;
        var res = new TreeNode();
        RecursionMerge(res, root1, root2);
        return res;
    }

    private void RecursionMerge(TreeNode cur, TreeNode? t1, TreeNode? t2)
    {
        if (t1 != null)
            cur.val += t1.val;
        if (t2 != null)
            cur.val += t2.val;
        cur.left = (t1?.left != null || t2?.left != null) ? new TreeNode() : null;
        cur.right = (t1?.right != null || t2?.right != null) ? new TreeNode() : null;
        if (cur.left != null)
            RecursionMerge(cur.left, t1?.left, t2?.left);
        if (cur.right != null)
            RecursionMerge(cur.right, t1?.right, t2?.right);
    }
}