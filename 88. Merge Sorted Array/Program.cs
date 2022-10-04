namespace _88._Merge_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int[] n2 = new int[] { 2, 5, 6 };
            Solution solution = new Solution();
            solution.Merge(n1, 3, n2, n2.Length);
            Console.WriteLine(String.Join(" ", n1));
        }
    }
}