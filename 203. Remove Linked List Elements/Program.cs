namespace _203._Remove_Linked_List_Elements;

internal class Program
{
    static void Main(string[] args)
    {
        ListNode l1 = new ListNode(1);
        ListNode l2 = new ListNode(2);
        ListNode l3 = new ListNode(3);
        ListNode l4 = new ListNode(4);

        l1.next = l2;
        l2.next = l3;
        l3.next = l4;
        Console.WriteLine(new Solution().RemoveElements(l1, 3));
    }
}
