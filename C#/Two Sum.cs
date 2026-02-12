public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            var comp = target - nums[i];
            if(dict.ContainsKey(comp))
            {
                return [i, dict[comp]];
            }
            if(!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
            }
        }

        return new int[] {};
    }
}   