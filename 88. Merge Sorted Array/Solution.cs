using System;
using System.Collections.Generic;
using System.Linq;

namespace _88._Merge_Sorted_Array;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] a2, int n)
    {
        int[] a1 = new int[m];
        for(int i = 0; i < m; i++)
            a1[i] = nums1[i];
        int resIndex = 0;
        int a1Index = 0, a2Index = 0;
        while (resIndex < nums1.Length)
        {
            int? n1 = a1Index < a1.Length ? a1[a1Index] : null;
            int? n2 = a2Index < a2.Length ? a2[a2Index] : null;
            int toWrite = 0;
            if (n1 != null && n2 != null)
            {
                toWrite = Math.Min(n1.Value,n2.Value);
                if (n1 < n2)
                    a1Index++;
                else
                    a2Index++;
            }
            else if(n1!=null)
            {
                toWrite = n1.Value;
                a1Index++;
            }
            else if(n2!=null)
            {
                toWrite = n2.Value;
                a2Index++;
            }
            nums1[resIndex++] = toWrite;
        }
    }
}
