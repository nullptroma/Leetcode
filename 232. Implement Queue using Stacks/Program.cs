namespace _232._Implement_Queue_using_Stacks;

internal class Program
{
    static void Main(string[] args)
    {
        int x = 5;
        MyQueue obj = new MyQueue();
        obj.Push(x);
        int param_2 = obj.Pop();
        int param_3 = obj.Peek();
        bool param_4 = obj.Empty();
    }
}
