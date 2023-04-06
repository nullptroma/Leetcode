using System.Numerics;

namespace _8._String_to_Integer__atoi_;

public class Solution {
    public int MyAtoi(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;
        BigInteger res = 0;
        int index = 0;
        while (index<s.Length && s[index] == ' ')
            index++;
        bool negative = index<s.Length && s[index] == '-';
        if (index<s.Length && "+-".Contains(s[index]))
            index++;
        while (index<s.Length && char.IsDigit(s[index]))
            res = res * 10 + s[index++]-'0';
        if (negative)
            res *= -1;
        if (res > int.MaxValue)
            return int.MaxValue;
        if (res < int.MinValue)
            return int.MinValue;
        return (int)res;
    }
}