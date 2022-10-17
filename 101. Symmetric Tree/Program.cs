namespace _101._Symmetric_Tree;

internal class Program
{
    static void Main(string[] args)
    {
        var t = new TreeNode(3, 
            new TreeNode(4, new TreeNode(5, new TreeNode(6), null), null), 
            new TreeNode(4, null, new TreeNode(5, null, new TreeNode(6)))
            );
        Console.WriteLine(new Solution().IsSymmetric(t));
    }
}
