using System;

namespace _15._3Sum;

class Program
{
    static void Main(string[] args)
    {
        var res = new Solution().ThreeSum(new int[]{-3,0,-5,2,-4,-2,1,-2,-1,3,1,3,1,3,-3,-5,1});
        foreach (var list in res)
        {
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
