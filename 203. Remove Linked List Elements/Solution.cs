namespace _203._Remove_Linked_List_Elements;

public class Solution
{
    public ListNode? RemoveElements(ListNode? head, int val)
    {
        ListNode? first = null;
        ListNode? current = null;
        while (head != null)
        {
            if (head.val == val)
            {
                head = head.next;
                continue;
            }
            if (first == null)
                first = current = head;
            else
            {
                current!.next = head;
                current = current.next;
            }
            var buf = head;
            head = head.next;
            buf.next = null;
        }
        return first;
    }
}
