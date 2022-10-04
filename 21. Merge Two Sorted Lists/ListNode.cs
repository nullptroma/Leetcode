namespace _21._Merge_Two_Sorted_Lists;

//Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

    public static ListNode Create(int[] nums)
    {
        ListNode l = new ListNode(nums[0]);
        ListNode cur = l;
        for (int i = 1; i < nums.Length; i++)
        {
            cur.next = new ListNode(nums[i]);
            cur = cur.next;
        }
        return l;
    }

    public override string ToString()
    {
        List<int> list = new List<int>();
        ListNode? cur = this;
        while (cur != null)
        {
            list.Add(cur.val);
            cur = cur.next;
        }
        return String.Join(" ", list);
    }
}
