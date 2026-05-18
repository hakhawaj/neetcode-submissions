public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, List<string>>();

        foreach (string s in strs)
        {
            var counts = new int[26];
            foreach (char c in s)
            {
                counts[c - 'a']++;
            }

            string key = string.Join(",", counts);

            if (!groups.ContainsKey(key)) groups.Add(key, new List<string>());

            groups[key].Add(s);
        }

        return groups.Values.ToList();
    }
}
