namespace _701._Insert_into_a_Binary_Search_Tree;

public class Solution
{
    public TreeNode InsertIntoBST(TreeNode root, int val)
    {
        if(root == null)
            return new TreeNode(val);
        TreeNode cur = root;
        while(true)
        {
            int curVal = cur.val;
            if(val < curVal)
            {
                if (cur.left == null)
                {
                    cur.left = new TreeNode(val);
                    break;
                }
                cur = cur.left;
            }
            else
            {
                if (cur.right == null)
                {
                    cur.right = new TreeNode(val);
                    break;
                }
                cur = cur.right;
            }
        }
        return root;
    }
}