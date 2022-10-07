namespace _344._Reverse_String;

internal class Program
{
    static void Main(string[] args)
    {
        var arr = "Hello, World!".ToArray();
        new Solution().ReverseString(arr);
        Console.WriteLine(String.Join("", arr));
    }
}