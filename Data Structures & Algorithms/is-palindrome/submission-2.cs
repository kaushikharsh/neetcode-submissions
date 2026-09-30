public class Solution {
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
