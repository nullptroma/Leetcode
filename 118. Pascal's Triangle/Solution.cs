namespace _118._Pascal_s_Triangle;

public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        List<IList<int>> triangle = new List<IList<int>>() { new List<int> { 1 } };
        if (numRows > 1)
            triangle.Add(new List<int>() { 1, 1 });
        numRows -= 2;
        while (numRows-- > 0)
        {
            IList<int> prev = triangle[^1];
            int nextCount = prev.Count;
            List<int> row = new List<int>() { 1 };
            for (int i = 1; i < nextCount; i++)
            {
                row.Add(prev[i - 1] + prev[i]);
            }
            row.Add(1);
            triangle.Add(row);
        }

        return triangle;
    }
}