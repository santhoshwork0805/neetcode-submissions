public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string, List<string>> dictAnagram = new(); 
        foreach(var s in strs)
        {
            char[] ch = s.ToCharArray();
            Array.Sort(ch);
            string sorted = new string(ch);
            if(dictAnagram.ContainsKey(sorted))
            {
                dictAnagram[sorted].Add(s);
            }
            else
            {
                dictAnagram[sorted] = new List<string>{s};
            }
        }
        var result = dictAnagram.Values.ToList();
        return result;
    }
}
