using System.Text;

namespace _299._Bulls_and_Cows;

public class Solution
{
    public string GetHint(string secret, string guess)
    {
        StringBuilder secretSb = new StringBuilder(secret);
        StringBuilder guessSb = new StringBuilder(guess);

        Dictionary<char, int> secretCount = new Dictionary<char, int>();
        Dictionary<char, int> guessCount = new Dictionary<char, int>();
        int A = 0;
        int B = 0;
        for(int i = 0; i < secret.Length + 1; i++)
        {
            if (i < secret.Length && secretSb[i] == guessSb[i])
            {
                secretSb[i] = '*';
                guessSb[i] = '*';
                A++;
            }
            if (i > 0)
            {
                int index = i - 1;
                if (secretSb[index] == '*')
                    continue;
                char key1 = secretSb[index];
                if (secretCount.ContainsKey(key1))
                    secretCount[key1]++;
                else
                    secretCount.Add(key1, 1);

                char key2 = guessSb[index];
                if (guessCount.ContainsKey(key2))
                    guessCount[key2]++;
                else
                    guessCount.Add(key2, 1);
            }
        }
        foreach (var kp in secretCount)
        {
            if (guessCount.ContainsKey(kp.Key) == false)
                continue;
            B += Math.Min(kp.Value, guessCount[kp.Key]);
        }
        return $"{A}A{B}B";
    }
}