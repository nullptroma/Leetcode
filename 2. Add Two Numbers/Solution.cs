namespace _2._Add_Two_Numbers;

public class Solution {
    public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        ListNode? answer = null;
        ListNode? answerEnd = answer;
        int toNext = 0;
        while (l1!=null || l2!=null)
        {
            int sum = 0;
            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }

            sum += toNext;
            toNext = sum / 10;
            sum %= 10;
            ListNode item = new ListNode(sum);
            if (answer == null)
                answer = answerEnd = item;
            else
            {
                answerEnd.next = item;
                answerEnd = item;
            }
        }

        if (toNext != 0)
            answerEnd.next = new ListNode(toNext);
        return answer;
    }
}