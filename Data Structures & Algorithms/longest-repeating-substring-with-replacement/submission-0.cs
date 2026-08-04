public class Solution {
    public int CharacterReplacement(string s, int k) {

      int left = 0;
      int maxFreq = 0;
      int maxLength=0;
      Dictionary<char, int> hashMap = new();

      for(int right =0;right < s.Length; right++)
      {
         if(!hashMap.ContainsKey(s[right]))
         {
            hashMap[s[right]] = 1;
         }
         else
         {
            hashMap[s[right]]++;
         }
         maxFreq = Math.Max(maxFreq, hashMap[s[right]]);

         while((right-left+1)-maxFreq > k){
            hashMap[s[left]]--;
            left++;
         }

         maxLength = Math.Max(maxLength, right-left+1);
      } 
      return maxLength;
    }
}
