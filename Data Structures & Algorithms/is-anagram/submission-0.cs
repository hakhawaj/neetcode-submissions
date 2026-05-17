public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        var sDict = new int[26];
        var tDict = new int[26];

        foreach (char c in s)
        {
            sDict[c - 'a']++;
        }

        foreach (char c in t)
        {
            tDict[c - 'a']++;
        }

        for (int i = 0; i < sDict.Length; i++)
        {
            if (sDict[i] != tDict[i]) return false;
        }

        return true;
    }
}
