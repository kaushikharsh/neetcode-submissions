public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> frequency_map = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(frequency_map.ContainsKey(nums[i])){
                return true;
            }
            frequency_map[nums[i]] = 1;
        }
        return false;
    }
}