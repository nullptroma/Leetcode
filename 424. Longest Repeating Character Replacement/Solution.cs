namespace _424._Longest_Repeating_Character_Replacement;

public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        List<Counter> counters = new List<Counter>();
        int max = 0;
        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            for (int cIndex = 0; cIndex < counters.Count; cIndex++)
            {
                Counter curC = counters[cIndex];
                curC.Add(ch);
                if (curC.IsValid == false)
                {
                    max = Math.Max(max, curC.ValidLength);
                    counters.RemoveAt(cIndex);
                    cIndex--;
                }
            }
            counters.Add(new Counter(ch, k));
        }
        foreach (Counter curC in counters)
            max = Math.Max(max, curC.ValidLength);
        return max;
    }

    private class Counter
    {
        public int Length { get; private set; }
        public bool IsValid => _maxMisses >= Length- _maxCount;
        public int ValidLength => _maxCount + Math.Min(Length- _maxCount, _maxMisses);
        private int[] _letters = new int[26];
        private int _maxCount => _letters[_maxLetter-65];
        private char _maxLetter;
        private readonly int _maxMisses;

        public Counter(char ch, int k)
        {
            _maxMisses = k;
            Length = 1;
            _letters[ch - 65] = 1;
            _maxLetter = ch;
        }

        public void Add(char ch)
        {
            _letters[ch - 65]+=1;
            if (_letters[ch - 65] > _maxCount)
                _maxLetter = ch;
            Length++;
        }
    }
}