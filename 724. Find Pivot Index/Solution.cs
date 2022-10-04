using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _724._Find_Pivot_Index;

public class Solution
{
    public int PivotIndex(int[] nums)
    {
        int[] sumsFromLeft = new int[nums.Length];
        int[] sumsFromRight = new int[nums.Length];
        for(int i = 1; i < nums.Length; i++)
            sumsFromLeft[i] = nums[i - 1] + sumsFromLeft[i - 1];

        for (int i = nums.Length - 2; i >= 0; i--)
            sumsFromRight[i] = nums[i + 1] + sumsFromRight[i + 1];
        Console.WriteLine(String.Join(" ", sumsFromLeft));
        Console.WriteLine(String.Join(" ", sumsFromRight));
        return 0;
    }
}
