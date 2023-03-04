using System.Text;

namespace _6._Zigzag_Conversion;

public class Solution {
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
            return s;
        int stepDown = (numRows-2) * 2 + (numRows>0 ? 1 : 0);
        int stepTop = 0;
        StringBuilder sb = new StringBuilder();
        for (int start = 0; start < numRows; start++)
        {
            int j = start;
            bool toDown = true;
            while (j<s.Length)
            {
                sb.Append(s[j]);
                if (stepDown == 0)
                    j += stepTop;
                else if (stepTop == 0)
                    j += stepDown;
                else if (toDown)
                    j += stepDown;
                else
                    j += stepTop;
                j++;
                toDown = !toDown;
            }
            stepDown -= 2;
            if (stepDown < 0)
                stepDown = 0;
            if (stepTop == 0)
                stepTop = 1;
            else
                stepTop += 2;
        }
        return sb.ToString();
    }
}