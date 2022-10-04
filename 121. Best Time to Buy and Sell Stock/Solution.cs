namespace _121._Best_Time_to_Buy_and_Sell_Stock;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int min = prices[0];
        int max = prices[0];
        bool hasMax = false;
        int res = 0;
        foreach (int price in prices)
        {
            if (price > max || hasMax == false)
            {
                max = price;
                hasMax = true;
                res = Math.Max(max - min, res);
            }
            if (price < min)
            {
                min = price;
                hasMax = false;
            }
        }
        return res > 0 ? res : 0;
    }
}
