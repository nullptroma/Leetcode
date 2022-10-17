namespace _190._Reverse_Bits;

public class Solution
{
    public uint reverseBits(uint n)
    {
        uint res = 0;
        int count = 32;
        while(count-- > 0)
        {
            res <<= 1;
            res += n & 1;
            n >>= 1;
        }
        return res;
    }
}