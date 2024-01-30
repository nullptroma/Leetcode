namespace _232._Implement_Queue_using_Stacks;

public class MyQueue
{
    private Stack<int> _sInput = new Stack<int>(256);
    private Stack<int> _sOutput = new Stack<int>(256);

    public void Push(int x)
    {
        _sInput.Push(x);
    }

    public int Pop()
    {
        if (_sOutput.Count > 0)
            return _sOutput.Pop();
        
        while (_sInput.TryPop(out int res))
            _sOutput.Push(res);
        return _sOutput.Pop();
    }

    public int Peek()
    {
        if (_sOutput.Count > 0)
            return _sOutput.Peek();
        
        while (_sInput.TryPop(out int res))
            _sOutput.Push(res);
        return _sOutput.Peek();
    }

    public bool Empty()
    {
        return _sOutput.Count == 0 && _sInput.Count == 0;
    }
}
