namespace _83._Remove_Duplicates_from_Sorted_List;

internal class Program
{
    static void Main(string[] args)
    {
        ListNode l1 = new ListNode(1);
        ListNode l2 = new ListNode(1);
        ListNode l3 = new ListNode(4);
        ListNode l4 = new ListNode(4);

        l1.next = l2;
        l2.next = l3;
        l3.next = l4;
        Console.WriteLine(new Solution().DeleteDuplicates(null));
    }
}
