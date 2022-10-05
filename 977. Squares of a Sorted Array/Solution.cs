namespace _977._Squares_of_a_Sorted_Array;

public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int[] res = new int[nums.Length];
        int firstNonNegative = -1;
        for(int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= 0)
            {
                firstNonNegative = i;
                break;
            }
        }

        int resIndex = 0;
        int positiveIndex = firstNonNegative;
        int negativeIndex = firstNonNegative!=-1 ? positiveIndex - 1 : nums.Length-1;
        while(resIndex < nums.Length)
        {
            if(negativeIndex>=0 && positiveIndex < nums.Length && positiveIndex>=0)
            {
                if (nums[negativeIndex]*-1 < nums[positiveIndex])
                {
                    res[resIndex++] = nums[negativeIndex] * nums[negativeIndex];
                    negativeIndex--;
                }
                else
                {
                    res[resIndex++] = nums[positiveIndex] * nums[positiveIndex];
                    positiveIndex++;
                }
            }
            else if(negativeIndex >= 0)
            {
                res[resIndex++] = nums[negativeIndex]* nums[negativeIndex];
                negativeIndex--;
            }
            else if(positiveIndex >= 0)
            {
                res[resIndex++] = nums[positiveIndex] * nums[positiveIndex];
                positiveIndex++;
            }
        }
        return res;
    }
}