namespace _150._Evaluate_Reverse_Polish_Notation;

public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>(tokens.Length);
        foreach (var token in tokens)
        {
            if (int.TryParse(token, out var number))
                stack.Push(number);
            else
            {
                int right = stack.Pop();
                int left = stack.Pop();
                char op = token[0];
                stack.Push(Calc(op, left, right));
            }
        }
        return stack.Pop();
    }

    private int Calc(char op, int left, int right) => op switch
    {
        '+' => left + right,
        '-' => left - right,
        '*' => left * right,
        '/' => left / right,
        _ => throw new ArgumentOutOfRangeException()
    };
}