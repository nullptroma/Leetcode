namespace _344._Reverse_String;

public class Solution
{
    public void ReverseString<T>(T[] arr)
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            T buf = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = buf;
        }
    }
}
