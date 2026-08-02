public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0;
        int r = s.Length-1;
        while(l<r){

          while(l < r && !char.IsLetterOrDigit(s[l])) //skip non aplanumeric value
          l++;
          
          while(l < r && !char.IsLetterOrDigit(s[r]))
          r--;

          if(char.ToLowerInvariant(s[l]) != char.ToLowerInvariant(s[r])) //invariant culture
           return false;
           l++;
           r--;
        }
        return true;
    }
}
