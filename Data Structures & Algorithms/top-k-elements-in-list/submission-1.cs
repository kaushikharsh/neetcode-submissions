public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for(int i=0;i<nums.Length;i++){
            if(map.ContainsKey(nums[i])){
                map[nums[i]]++;
            }else{
                map[nums[i]] = 1;
            }
        }

        int[] result = new int[k];

        var sorted_map = map.OrderByDescending(x=>x.Value);

        int l = 0;
        foreach(var item in sorted_map){
            if(l==k){
                break;
            }
            result[l] = item.Key;
            l++;
        }

        return result;
    }
}
