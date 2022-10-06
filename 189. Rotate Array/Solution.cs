namespace _189._Rotate_Array;

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        k %= nums.Length;
        if (k == 0)
            return;
        int oneCycleLen = nums.Length / GCD(nums.Length, k);
        for (int i = 0; i < nums.Length / oneCycleLen; i++)
            MoveTo(nums, nums[i], i + k, k, oneCycleLen);
    }

    private static void MoveTo(int[] array, int value, int to, int step, int curLen)
    {
        while (curLen-- > 0)
        {
            if (to >= array.Length)
                to -= array.Length;
            int buf = array[to];
            array[to] = value;
            to += step;
            value = buf;
        }
    }

    private static int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }


}
