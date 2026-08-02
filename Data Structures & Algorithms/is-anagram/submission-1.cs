public class Solution {
    public bool IsAnagram(string s, string t) {
      Dictionary<char, int> map = new();

      foreach(var c in s)
      {
        if(map.ContainsKey(c)){
            map[c]++;
        }else
        {
        map.Add(c, 1);
        }
      }

      foreach(var c in t)
      {
        if(!map.ContainsKey(c))
        {
            return false;
        }
        else
        {
            map[c]--;
        }
        if(map[c] == 0){
            map.Remove(c);
        }
      }
      return map.Count == 0;
    }
}
