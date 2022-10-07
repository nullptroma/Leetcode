namespace _102._Binary_Tree_Level_Order_Traversal;

public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        List<IList<int>> output = new List<IList<int>>();
        RecursiveTraversal(output, new List<TreeNode>() { root });
        return output;
    }

    private void RecursiveTraversal(List<IList<int>> output, List<TreeNode> curLevel)
    {
        if (curLevel.Count == 0)
            return;
        List<int> levelValues = new List<int>();
        foreach (var n in curLevel)
        {
            if (n == null)
                continue;
            levelValues.Add(n.val);
        }
        if (levelValues.Count == 0)
            return;
        output.Add(levelValues);

        List<TreeNode> nextLevel = new List<TreeNode>();
        foreach (var n in curLevel)
        {
            if (n == null)
                continue;
            if (n.left != null)
                nextLevel.Add(n.left);
            if (n.right != null)
                nextLevel.Add(n.right);
        }
        RecursiveTraversal(output, nextLevel);
    }
}
