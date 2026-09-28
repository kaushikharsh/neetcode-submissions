public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if(strs.Length <= 1){
            return new List<List<string>>
            {
                new List<string>(strs)
            };
        }
        int n = strs.Length;
        //Make a frequency map for every string and create 
        //Dictionary<Dictionary<char,int>, List<string>>
        Dictionary<string,List<string>> map = 
        new Dictionary<string,List<string>>();
        for(int i = 0; i < strs.Length; i++){
            Dictionary<char,int> freq_map = FrequencyMap(strs[i]);
            
            string key = "";
            for(char ch = 'a'; ch <= 'z'; ch++){
                if(freq_map.ContainsKey(ch))
                key = key + ch + freq_map[ch];
            }

            if(map.ContainsKey(key)){
                map[key].Add(strs[i]);
                continue;
            }
            map[key] = new List<string>{strs[i]};
        }

        

        List<List<string>> result = new List<List<string>>();
        foreach(KeyValuePair<string, List<string>> temp_map in map){
            result.Add(temp_map.Value);
        }

        return result;
    }

    public Dictionary<char, int> FrequencyMap(string s){
        Dictionary<char, int> freq_map = new Dictionary<char, int>();
        for(int i=0 ;i < s.Length; i++){
            if(freq_map.ContainsKey(s[i])){
                freq_map[s[i]]++;
            }
            else{
                freq_map[s[i]] = 1;
            }
        }
        return freq_map;
    }
}
