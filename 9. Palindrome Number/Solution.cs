namespace _9._Palindrome_Number;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;
        if (x < 10)
            return true;
        List<byte> digits = new List<byte>(32);
        while (x != 0)
        {
            digits.Add((byte)(x%10));
            x /= 10;
        }

        int half = digits.Count / 2;
        for (int i = 0; i < half; i++)
            if (digits[i] != digits[digits.Count - 1 - i])
                return false;

        return true;
    }
}