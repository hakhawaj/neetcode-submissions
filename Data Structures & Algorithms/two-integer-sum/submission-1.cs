public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var index = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (index.ContainsKey(diff)) return new int[] {index[diff], i};
            index.Add(nums[i], i);
        }

        return new int[] {0, 0};
    }
}
