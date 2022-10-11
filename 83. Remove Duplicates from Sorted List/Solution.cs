namespace _83._Remove_Duplicates_from_Sorted_List;

public class Solution
{
    public ListNode? DeleteDuplicates(ListNode? head)
    {
        ListNode? first = null;
        ListNode? current = null;
        while (head != null)
        {
            if (first == null)
                first = current = head;
            if (head.val == current!.val)
            {
                head = head.next;
                continue;
            }
            current!.next = head;
            current = current.next;
            head = head.next;
        }
        if (current != null)
            current.next = null;
        return first;
    }
}