namespace _189._Rotate_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6};
            new Solution().Rotate(arr, 3);
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}