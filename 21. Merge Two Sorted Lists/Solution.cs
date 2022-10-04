namespace _21._Merge_Two_Sorted_Lists;

public class Solution
{
    public ListNode MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        ListNode? start = null;
        ListNode? current = null;
        List<ListNode?> listNodes = new List<ListNode?>() { list1, list2 };
        while (listNodes.Any(l => l != null))
        {
            int i = MinIndex(listNodes);
            ListNode? curMin = listNodes[i];
            listNodes[i] = listNodes[i]!.next;

            if (start == null)
            {
                start = curMin;
                current = start;
            }
            else if (current != null)
            {
                current.next = curMin;
                current = current.next;
            }
        }
        return start!;
    }

    private int MinIndex(List<ListNode?> list)
    {
        int minValue = int.MaxValue;
        int index = -1;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i]?.val < minValue)
            {
                minValue = list[i]!.val;
                index = i;
            }
        }
        return index;
    }
}