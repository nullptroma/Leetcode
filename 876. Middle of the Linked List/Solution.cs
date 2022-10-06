namespace _876._Middle_of_the_Linked_List;

public class Solution
{
    public ListNode MiddleNode(ListNode? head)
    {
        ListNode result = head!;
        while (head?.next != null)
        {
            head = head?.next?.next;
            result = result!.next!;
        }
        return result;
    }
}
