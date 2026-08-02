public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dictAnagram = new Dictionary<string, List<string>>();
        if(strs.Length == 1)
        {
         return new List<List<string>>{new List<string>{strs[0]}};
        }
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
