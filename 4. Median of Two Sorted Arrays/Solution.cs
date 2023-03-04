namespace _4._Median_of_Two_Sorted_Arrays;

public class Solution
{
    private int _left = 0;
    private int _right = 0;
    
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int i1 = 0;
        int i2 = 0;
        int size = nums1.Length + nums2.Length;
        while (i1 + i2 < size / 2+1 && (i1 < nums1.Length || i2 < nums2.Length))
        {
            if(i1 < nums1.Length && i2 >= nums2.Length)
                Push(nums1[i1++]);
            else if(i1 >= nums1.Length && i2 < nums2.Length) 
                Push(nums2[i2++]);
            else if (nums1[i1] < nums2[i2])
                Push(nums1[i1++]);
            else
                Push(nums2[i2++]);
        }
        return size%2==1?_right : (_left+_right)/2.0;
    }

    private void Push(int num)
    {
        _left = _right;
        _right = num;
    }
}