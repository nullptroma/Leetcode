namespace _142._Linked_List_Cycle_II;

internal class Program
{
    static void Main(string[] args)
    {
        var l1 = new ListNode(3);
        var l2 = new ListNode(2);

        l1.next = l2;
        l2.next = l1;
        Console.WriteLine(new Solution().DetectCycle(l1)?.val);
    }
}