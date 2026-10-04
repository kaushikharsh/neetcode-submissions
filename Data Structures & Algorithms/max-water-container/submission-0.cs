public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0;
        int r = heights.Length - 1;
        int max_amount = 0;
        while(l<r){
            max_amount = Math.Max(max_amount,((r-l)*Math.Min(heights[l],heights[r])));
            if(heights[l] <= heights[r]){
                l++;
            }
            else if(heights[r] < heights[l]){
                r--;
            }
        }
        return max_amount;
    }
}
