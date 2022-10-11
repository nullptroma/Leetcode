namespace _235._Lowest_Common_Ancestor_of_a_Binary_Search_Tree;

internal class Program
{
    static void Main(string[] args)
    {
        TreeNode root = new TreeNode(6);
        root.left = new TreeNode(2) { left = new TreeNode(0), right = new TreeNode(4) { left = new TreeNode(3), right = new TreeNode(5) } };
        root.right = new TreeNode(8) { left = new TreeNode(7), right = new TreeNode(9) };
        Console.WriteLine(new Solution().LowestCommonAncestor(root, new TreeNode(3), new TreeNode(5))?.val);
    }
}
