namespace _509._Fibonacci_Number;

public class Solution
{
    public int Fib(int n)
    {
        if (n == 0)
            return 0;
        n--;
        int cur0 = 0;
        int cur1 = 1;
        while (--n > 0)
        {
            int buf = cur0 + cur1;
            cur0 = cur1;
            cur1 = buf;
        }
        return cur0 + cur1;
    }
}