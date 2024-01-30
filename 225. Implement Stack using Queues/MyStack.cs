namespace _225._Implement_Stack_using_Queues;

public class MyStack
{
    private Queue<int> _queue = new Queue<int>(256);
    private int? _lastNum = null;

    public MyStack()
    {
    }

    public void Push(int x)
    {
        if (_lastNum == null)
        {
            _lastNum = x;
            return;
        }

        int count = _queue.Count;
        _queue.Enqueue(_lastNum.Value);
        _lastNum = x;
        while (count-- > 0)
            _queue.Enqueue(_queue.Dequeue());
    }

    public int Pop()
    {
        if (_lastNum != null)
        {
            int res = _lastNum.Value;
            _lastNum = null;
            return res;
        }

        return _queue.Dequeue();
    }

    public int Top()
    {
        if (_lastNum != null)
            return _lastNum.Value;
        return _queue.Peek();
    }

    public bool Empty()
    {
        return _lastNum == null && _queue.Count == 0;
    }
}