public class Solution {
    public bool IsAnagram(string s, string t) {
     var dictA = new Dictionary<char, int>();
     var dictB = new Dictionary<char, int>();
     foreach(char c in s){
        if(dictA.ContainsKey(c)){
            dictA[c]++;
        }
        else
        {
            dictA.Add(c, 1);
        }
     }
     foreach(char c in t){
        if(dictB.ContainsKey(c)){
            dictB[c]++;
        }
        else
        {
            dictB.Add(c, 1);
        }
     }
    return dictA.Count == dictB.Count 
     && dictA.All(kvp => dictB.TryGetValue(kvp.Key, out var value2)
     && value2==kvp.Value);
     }
}
