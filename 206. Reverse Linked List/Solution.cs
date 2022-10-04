namespace _206._Reverse_Linked_List;

public class Solution
{
    public ListNode? ReverseList(ListNode head)
    {
        if (head == null || head.next == null)
            return head;
        ListNode cur = head;
        ListNode newHead = cur.next!;
        cur.next = null;
        while (true)
        {
            ListNode? buf = newHead.next;
            newHead.next = cur;
            if (buf == null)
                return newHead;
            cur = newHead;
            newHead = buf;
        }
    }
}
