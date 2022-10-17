namespace _77._Combinations;

public class Solution
{
    public IList<IList<int>> Combine(int n, int k)
    {
        List<IList<int>> res = new List<IList<int>>();
        Recursion(res, new List<int>(), 1, n, k);
        return res;
    }

    private void Recursion(List<IList<int>> result, List<int> cur, int minNum, int maxNum, int count)
    {
        if (cur.Count == count)
        {
            result.Add(cur.ToList());
            return;
        }
        for (int toAdd = minNum; toAdd <= maxNum; toAdd++)
        {
            cur.Add(toAdd);
            Recursion(result, cur, toAdd + 1, maxNum, count);
            cur.RemoveAt(cur.Count-1);
        }
    }
}