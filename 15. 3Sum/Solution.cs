using System;
using System.Collections.Generic;
using System.Linq;

namespace _15._3Sum;

public class Solution {
    
    class SequenceComparer<T>:IEqualityComparer<IEnumerable<T>>
    {
        public bool Equals(IEnumerable<T> seq1,IEnumerable<T> seq2)
        {
            return seq1.SequenceEqual(seq2);
        }
    
        public int GetHashCode(IEnumerable<T> seq)
        {
            int hash = 1234567;
            foreach(T elem in seq)
                hash = unchecked(hash * 37 + elem.GetHashCode());
            return hash;
        }
    }
    
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
                dict[num]++;
            else
                dict.Add(num, 1);
        }
        HashSet<IList<int>> answer = new HashSet<IList<int>>(new SequenceComparer<int>());
        int[] keys = dict.Keys.ToArray();
        for (int i = 0; i < keys.Length; i++)
        {
            int countI = dict[keys[i]]-1;
            for (int j = i; j < keys.Length; j++)
            {
                int countJ = j == i ? (countI-1) : (dict[keys[j]]-1);
                int v1 = keys[i];
                int v2 = keys[j];
                int v3 = -(v1+v2);
                if (v3 == v1)
                    countI--;
                if (v3 == v2)
                    countJ--;
                bool can = dict.ContainsKey(v3);
                if (can && countI >= 0 && countJ >= 0)
                {
                    var list = new List<int>() { v1, v2, v3 };
                    list.Sort();
                    answer.Add(list);
                }
                countI = dict[keys[i]]-1;
            }
        }
        
        return answer.ToList();
    }
}