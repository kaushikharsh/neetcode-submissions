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

        //Make a bucket list using bucket sort concept , why nums.Length + 1 , because an element can come
        //till n times in the array
        //so we will make the buck like this below
        //buckets
        // ↓
        // ┌───────┬───────┬───────┬───────┬───────┐
        // │   0   │   1   │   2   │   3   │   4   │
        // └───────┴───────┴───────┴───────┴───────┘
        //             ↓       ↓       ↓
        //         [3]     [2]     [1, 4]
        List<int>[] bucket =  new List<int>[nums.Length + 1];  

        foreach(KeyValuePair<int, int> item in map){
            var number = item.Key;
            var frequency = item.Value;
            
            if (bucket[frequency] == null)
            {
                bucket[frequency] = new List<int>();
            }

            bucket[frequency].Add(number);
        }

        int[] result = new int[k];
        int n = nums.Length + 1;
        int index = 0;
        
        for(int i = nums.Length ; i >= 1; i-- ){

            if(bucket[i] == null)
            {
                continue;
            }

            List<int> temp_list = bucket[i];

            for(int j = 0 ; j < temp_list.Count; j++){
                
                result[index] = temp_list[j];
                index++;

                if(index == k){
                    return result;
                }
            }
            
        }

        return result;
    }
}
