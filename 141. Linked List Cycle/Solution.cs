namespace _141._Linked_List_Cycle;

public class Solution
{
    public bool HasCycle(ListNode head)
    {
        if (head == null)
            return false;
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
        if ((curAbs & bit) != 0)
            return true;
        return false;
    }
}
