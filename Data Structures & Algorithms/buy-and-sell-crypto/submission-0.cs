public class Solution {
    public int MaxProfit(int[] prices) {
        int max_result  = 0;
        int l = 0;
        int r = l + 1;
        int length = prices.Length;
        int buying_price = 0;
        while(l < length && r < length){
            if(prices[r] < prices[l]){
                buying_price = prices[r];
                l++;
                r=l+1;
            }else if(prices[r] > prices[l]){
                max_result = Math.Max(max_result,(prices[r] - prices[l]));
                r++;
            }else{
                r++;
            }
        }
        return max_result;
    }
}
