public class Solution {
    public bool IsPalindrome(string s) {
        s = FilterOnlyAlphanumeric(s.ToLower());
        Console.WriteLine(s);
        int i = 0;
        int j = s.Length - 1;
        while(i<j){
            if(s[i] != s[j])
            return false;
            i++;
            j--;
        }
        return true;
    }
    private string FilterOnlyAlphanumeric(string s){
        string filtered_string  = "";
        for(int i=0;i<s.Length;i++){
            if((s[i] >= 'A' && s[i] <= 'Z')
            || (s[i] >= 'a' && s[i] <= 'z')
            || (s[i] >= '0' && s[i] <='9')){
                filtered_string += s[i];
            }
        }
        return filtered_string;
    }
}
