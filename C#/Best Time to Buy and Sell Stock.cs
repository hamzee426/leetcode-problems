public class Solution {
    public int MaxProfit(int[] prices) {
        var profit = 0;
        var prevProf = 0;
        var minPrice = prices[0];

        for(int i = 0; i < prices.Length; i++)
        {
            var currentPrice = prices[i];
            var prof = currentPrice - minPrice;
            if (prof > 0 && prof > prevProf)
            {
                profit = prof;
                prevProf = prof;
            }

            if (currentPrice < minPrice)
            {
                minPrice = currentPrice;
            }
        }

        return profit;
    }
}