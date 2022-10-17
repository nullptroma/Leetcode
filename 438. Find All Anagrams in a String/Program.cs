namespace _438._Find_All_Anagrams_in_a_String;

internal class Program
{
    static void Main(string[] args)
    {
        var res = new Solution().FindAnagrams("cbaebabacd", "abc");
        Console.WriteLine(String.Join(" ", res));
    }
}
