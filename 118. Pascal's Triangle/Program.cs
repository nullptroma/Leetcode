namespace _118._Pascal_s_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = new Solution().Generate(300);
            foreach(var r in res)
                Console.WriteLine(String.Join(" ", r));
        }
    }
}