public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        var countS = new Dictionary<char, int>();
        var countT = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!countS.ContainsKey(s[i]))
            {
                countS.Add(s[i], 0);
            }
            countS[s[i]]++;
            if (!countT.ContainsKey(t[i]))
            {
                countT.Add(t[i], 0);
            }
            countT[t[i]]++;
        }

        return (countS.Count == countT.Count &&
        !countS.Except(countT).Any());
    }
}
