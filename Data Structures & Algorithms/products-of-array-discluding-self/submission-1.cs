public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // First solution with division operator
        int numZeroes = 0;
        int product = 1;
        foreach (int num in nums)
        {
            if (num == 0)
            {
                numZeroes++;
            }
            else
            {
                product *= num;
            }
        }

        if (numZeroes > 1) return new int[nums.Length];

        var res = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            if (numZeroes == 1)
            {
                res[i] = (nums[i] == 0) ? product : 0;
            }
            else
            {
                res[i] = product / nums[i];
            }
        }

        return res;
    }
}
