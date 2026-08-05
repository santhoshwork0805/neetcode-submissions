public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        
        if(s1.Length > s2.Length)
        return false;

        int[] s1Count = new int[26];
        int[] currentWindowCount = new int[26];
        for(int i = 0;i< s1.Length;i++) //iterate first k elements
        {
            s1Count[s1[i]- 'a']++;
            currentWindowCount[s2[i] - 'a']++;
        }
        if(Match(s1Count, currentWindowCount))
         return true;

        for(int right=s1.Length;right < s2.Length; right++){
            
            currentWindowCount[s2[right] - 'a']++;
            currentWindowCount[s2[right-s1.Length]-'a']--;

            if(Match(s1Count, currentWindowCount))
            return true;
        }
        return false;
    }

    public bool Match(int[]a, int[]b){

        for(int i = 0;i< 26;i++){
            if(a[i] != b[i]){
                return false;
            }
        }
        return true;
    }
}
