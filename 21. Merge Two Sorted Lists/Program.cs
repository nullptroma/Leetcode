namespace _21._Merge_Two_Sorted_Lists;

internal class Program
{
    static void Main(string[] args)
    {
        var l1 = ListNode.Create(new int[] { 1, 2, 4 });
        var l2 = ListNode.Create(new int[] { 1, 3, 4 });
        Console.WriteLine(new Solution().MergeTwoLists(l1, l2));
    }
}