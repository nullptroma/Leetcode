using System.Text;

namespace _20._Valid_Parentheses;

public class Solution
{
    public bool IsValid(string s)
    {
        StringBuilder sb = new StringBuilder(s);
        if (sb.Length == 0)
            return true;
        if (sb.Length % 2 == 1)
            return false;
        while(sb.Length > 0)
        {
            char ch = sb[0];
            if ("({[".Contains(ch) == false)
                return false;
            char need = ch switch
            {
                '(' => ')',
                '{' => '}',
                '[' => ']',
                _ => '\0'
            };
            int count1 = 0;// ()
            int count2 = 0;// {}
            int count3 = 0;// []
            bool succes = false;
            for(int i = 1; i < sb.Length; i++)
            {
                char c = sb[i];
                if (count1 == 0 && count2 == 0 && count3 == 0 && c == need)
                {
                    sb.Remove(i, 1).Remove(0, 1);
                    succes = true;
                    break;
                }
                switch (c)
                {
                    case '(':
                        count1++;
                        break;
                    case ')':
                        count1--;
                        break;

                    case '{':
                        count2++;
                        break;
                    case '}':
                        count2--;
                        break;

                    case '[':
                        count3++;
                        break;
                    case ']':
                        count3--;
                        break;
                }
            }
            if(succes == false)
                return false;
        }
        return true;
    }
}