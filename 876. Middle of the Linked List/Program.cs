namespace _876._Middle_of_the_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var l1 = ListNode.Create(new int[] { 1,2,3,4,5});
            var l2 = ListNode.Create(new int[] { 1,2,3,4,5,6});
            Console.WriteLine(new Solution().MiddleNode(l1).val);
            Console.WriteLine(new Solution().MiddleNode(l2).val);
        }
    }
}