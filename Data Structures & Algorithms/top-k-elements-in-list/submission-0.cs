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
        int l = 0;

        while(l < k){
            int max = -1001;
            int count  = 0;
            foreach(KeyValuePair<int, int> temp in map){
                if(temp.Value > count){
                    count = temp.Value;
                    max = temp.Key;
                }
            }
            result[l] = max;
            if(map.ContainsKey(max))
            map.Remove(max);
            count = 0;
            max = -1001;
            l++;
        }

        return result;
    }
}
