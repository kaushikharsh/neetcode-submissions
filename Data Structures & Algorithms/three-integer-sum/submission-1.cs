public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> result = new List<List<int>>();
        for(int i=0;i<nums.Length;i++){
            if(i>0 && nums[i-1] == nums[i]){
                continue;
            }
            int target = -1*nums[i];
            int l = i + 1;
            int r = nums.Length - 1;
            while(l<r && l<nums.Length){
                int temp_sum = nums[l] + nums[r];
                if(temp_sum == target){
                    if(result.Count > 0){
                        List<int> last_insert = result[result.Count-1];
                        if(last_insert[0] == nums[i] && last_insert[1] == nums[l] && last_insert[2] == nums[r]){
                            l++;
                            r--;
                            continue;
                        }
                    }
                    result.Add(new List<int>{nums[i],nums[l],nums[r]});
                    l++;
                    r--;
                }
                else if(temp_sum > target){
                    r--;
                }
                else if(temp_sum < target){
                    l++;
                }
            }
        }
        return result;
    }
}
