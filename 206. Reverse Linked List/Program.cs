namespace _206._Reverse_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var l = ListNode.Create(new int[] { 1 });
            Console.WriteLine(new Solution().ReverseList(l));
        }
    }
}