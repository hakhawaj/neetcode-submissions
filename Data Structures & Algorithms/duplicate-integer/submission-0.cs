public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums.Length <= 1) return false;

        var numSet = new HashSet<int>();

        foreach (int num in nums)
        {
            if (!numSet.Contains(num)) {
                numSet.Add(num);
            }
            else
            {
                return true;
            }
        }

        return false;
    }
}