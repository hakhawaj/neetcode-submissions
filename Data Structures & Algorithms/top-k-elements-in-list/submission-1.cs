public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Bucket sort solution
        // Time complexity: O(n)
        // Space complexity: O(n)

        // Get counts of elements
        var counts = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (!counts.ContainsKey(num)) counts.Add(num, 0);
            counts[num]++;
        }

        // Create buckets
        var buckets = new List<int>[nums.Length + 1];

        // Loop through counts and add to buckets
        foreach (var pair in counts)
        {
            var num = pair.Key;
            var freq = pair.Value;

            if (buckets[freq] == null) buckets[freq] = new List<int>();
            buckets[freq].Add(num);
        }

        var res = new List<int>();

        // Loop through buckets and add top k elements to res
        for (int i = buckets.Length - 1; i >= 0 && res.Count < k; i--)
        {
            var bucket = buckets[i];
            if (bucket == null) continue;

            foreach (int num in bucket)
            {
                res.Add(num);

                if (res.Count == k) break;
            }
        }

        return res.ToArray();
    }
}
