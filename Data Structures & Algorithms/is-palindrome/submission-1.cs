public class Solution {
    // public bool IsPalindrome(string s) {
    //     s = FilterOnlyAlphanumeric(s.ToLower());
    //     Console.WriteLine(s);
    //     int i = 0;
    //     int j = s.Length - 1;
    //     while(i<j){
    //         if(s[i] != s[j])
    //         return false;
    //         i++;
    //         j--;
    //     }
    //     return true;
    // }
    // private string FilterOnlyAlphanumeric(string s){
    //     string filtered_string  = "";
    //     for(int i=0;i<s.Length;i++){
    //         if((s[i] >= 'A' && s[i] <= 'Z')
    //         || (s[i] >= 'a' && s[i] <= 'z')
    //         || (s[i] >= '0' && s[i] <='9')){
    //             filtered_string += s[i];
    //         }
    //     }
    //     return filtered_string;
    // }
    public bool IsPalindrome(string s) {
        int i = 0;
        int j = s.Length - 1;
        while(i<j){
            if(!((s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= 'a' && s[i] <= 'z') || (s[i] >= '0' && s[i] <= '9'))
            || !((s[j] >= 'A' && s[j] <= 'Z') || (s[j] >= 'a' && s[j] <= 'z') || (s[j] >= '0' && s[j] <= '9'))){
                
                if(((s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= 'a' && s[i] <= 'z') || (s[i] >= '0' && s[i] <= '9'))
                && !((s[j] >= 'A' && s[j] <= 'Z') || (s[j] >= 'a' && s[j] <= 'z') || (s[j] >= '0' && s[j] <= '9')) ){
                    j--;
                }else if( !((s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= 'a' && s[i] <= 'z') || (s[i] >= '0' && s[i] <= '9'))
                && ((s[j] >= 'A' && s[j] <= 'Z') || (s[j] >= 'a' && s[j] <= 'z') || (s[j] >= '0' && s[j] <= '9'))){
                    i++;
                }else{
                    i++;
                    j--;
                }
                Console.WriteLine(s[i] + " and " + s[j]);
            }
            else {
                if(((s[i] >= 'A' && s[i] <= 'Z')
                && (s[j] >= 'a' && s[j] <= 'z'))){
                    if((s[i] + 32) != s[j]){
                        return false;
                    }
                }
                else if(((s[j] >= 'A' && s[j] <= 'Z')
                && (s[i] >= 'a' && s[i] <= 'z'))){
                     if((s[j] + 32) != s[i]){
                        return false;
                    }
                }else{
                    if(s[i] != s[j]){
                        return false;
                    }
                }
                i++;
                j--;
            }
        }
        return true;
    }
}
