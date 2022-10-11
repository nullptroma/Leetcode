namespace _617._Merge_Two_Binary_Trees;

internal class Program
{
    static void Main(string[] args)
    {
        TreeNode root1 = new TreeNode(1);
        root1.left = new TreeNode(3) { left = new TreeNode(5) };
        root1.right = new TreeNode(2);


        TreeNode root2 = new TreeNode(2);
        root2.left = new TreeNode(1) { right = new TreeNode(4) };
        root2.right = new TreeNode(3) { right = new TreeNode(7) };
        var res = new Write().LevelOrder(new Solution().MergeTrees(root1, root2)!);
        Console.WriteLine($"\nOutput");
        foreach (var row in res)
            Console.WriteLine(String.Join(" ", row));
    }

    public class Write
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
}
