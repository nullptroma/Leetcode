namespace _142._Linked_List_Cycle_II;

public class Solution
{
    public ListNode? DetectCycle(ListNode head)
    {
        if (head == null)
            return null;
        ListNode? cur = head;
        int bit = 1 << 28;
        int curAbs = 0;
        while (cur != null && (curAbs & bit) == 0)
        {
            cur.val ^= bit;
            cur = cur.next;
            if (cur != null)
                curAbs = cur.val < 0 ? (cur.val * -1) : cur.val;
        }
        cur = head;
        curAbs = cur.val < 0 ? (cur.val * -1) : cur.val;
        while (cur != null && (curAbs & bit) != 0)
        {
            cur.val ^= bit;
            cur = cur.next;
            if (cur != null)
                curAbs = cur.val < 0 ? (cur.val * -1) : cur.val;
        }
        return cur;
    }
}