namespace _19._Remove_Nth_Node_From_End_of_List;

public class Solution
{
    public ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        if (head.next == null)
            return null;
        ListNode? left = null;
        ListNode? right = head;
        n--;
        while (n-- > 0)
            right = right!.next;
        while (right!.next != null)
        {
            if (left == null)
                left = head;
            else
                left = left.next;
            right = right.next;
        }
        if (left != null)
        {
            left.next = left.next!.next;
            return head;
        }
        return head.next;
    }
}
