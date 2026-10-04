public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0;
        int j = numbers.Length - 1;
        while(i<j){
            int temp_sum = numbers[i] + numbers[j];
            if(temp_sum == target){
                return new int[]{i+1,j+1};
            }
            if(temp_sum > target){
                j--;
            }
            else if(temp_sum < target){
                i++;
            }
        }
        return new int[]{-1,-1};
    }
}
