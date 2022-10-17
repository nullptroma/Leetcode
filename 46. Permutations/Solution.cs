namespace _46._Permutations;

public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        List<IList<int>> l = new List<IList<int>>();
        Recursion(l, new List<int>(), nums.ToHashSet());
        return l;
    }

    private void Recursion(List<IList<int>> result, List<int> cur, HashSet<int> aviable)
    {
        if(aviable.Count == 0)
        {
            result.Add(cur);
            return;
        }

        foreach(var av in aviable)
        {
            var newAviable = aviable.ToHashSet();
            newAviable.Remove(av);

            var newCur = cur.ToList();
            newCur.Add(av);
            Recursion(result, newCur, newAviable);
        }
    }
}