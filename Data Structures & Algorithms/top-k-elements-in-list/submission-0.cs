public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var res = new List<int>();

        var counts = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (!counts.ContainsKey(num)) counts.Add(num, 0);
            counts[num]++;
        }

        var maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create(
            (x, y) => y.CompareTo(x)));

        foreach (int key in counts.Keys)
        {
            maxHeap.Enqueue(key, counts[key]);
        }

        while (k > 0)
        {
            res.Add(maxHeap.Dequeue());
            k--;
        }

        return res.ToArray();
    }
}
