namespace _232._Implement_Queue_using_Stacks;

public class MyQueue
{
    private Stack<int> _sInput = new Stack<int>();
    private Stack<int> _sOutput = new Stack<int>();

    public void Push(int x)
    {
        while (_sOutput.TryPop(out int res))
            _sInput.Push(res);
        _sInput.Push(x);
    }

    public int Pop()
    {
        while (_sInput.TryPop(out int res))
            _sOutput.Push(res);
        return _sOutput.Pop();
    }

    public int Peek()
    {
        while (_sInput.TryPop(out int res))
            _sOutput.Push(res);
        return _sOutput.Peek();
    }

    public bool Empty()
    {
        while (_sInput.TryPop(out int res))
            _sOutput.Push(res);
        return _sOutput.Count == 0;
    }
}
