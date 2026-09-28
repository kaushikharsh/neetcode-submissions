public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefix_left_arr = new int[nums.Length];

        for(int i=0;i<nums.Length;i++){
            if(i==0){
                prefix_left_arr[i] = nums[i];
                continue;
            }
            prefix_left_arr[i] = prefix_left_arr[i-1]*nums[i];
        }

        int[] prefix_right_arr = new int[nums.Length];

        for(int j=nums.Length-1;j>=0;j--){
            if(j==nums.Length-1){
                prefix_right_arr[j] = nums[j];
                continue;
            }
            prefix_right_arr[j] = prefix_right_arr[j+1]*nums[j];
        }

        int[] result = new int[nums.Length];
        for(int i=0;i<nums.Length;i++){
            if(i==0){
                result[i] = prefix_right_arr[i+1];
                continue;
            }
            else if(i==nums.Length-1){
                result[i] = prefix_left_arr[i-1];
                continue;
            }
            result[i] = prefix_left_arr[i-1]*prefix_right_arr[i+1];
        }
        return result;
    }
}
