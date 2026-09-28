public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }

        Dictionary<int, int> frequency_map = new Dictionary<int, int>();
        
        for(int i = 0;i < s.Length; i++){
            if(frequency_map.ContainsKey(s[i])){
                frequency_map[s[i]]++;
                continue;
            }
            frequency_map[s[i]] = 1;
        }

        for(int i=0;i < t.Length; i++){
            if(!frequency_map.ContainsKey(t[i])){
                return false;
            }
            frequency_map[t[i]]--;
        }

        foreach(KeyValuePair<int, int> temp in frequency_map){
            if(temp.Value > 0){
                return false;
            }
        }
        return true;
    }
}
