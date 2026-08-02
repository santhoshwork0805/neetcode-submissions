public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        foreach(int num in nums){
            if(dict.ContainsKey(num)){
                dict[num]++;
            }
            else{
                dict[num] = 1;
            }
        }
        var result = dict.OrderByDescending(kvp => kvp.Value)
        .Take(k).ToArray();
        int[] resultArray = new int[k];
          for(int i =0;i<k;i++){
             resultArray[i] = result[i].Key;
          }
          return resultArray;
    }
}
