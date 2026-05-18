public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();

        foreach (string str in strs)
        {
            int len = str.Length;

            sb.Append(len);
            sb.Append("#");
            sb.Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var res = new List<string>();

        int i = 0;

        while (i < s.Length)
        {
            int j = i;
            while (s[j] != '#')
            {
                j++;
            }
            int len = int.Parse(s.Substring(i, j - i));
            res.Add(s.Substring(j + 1, len));
            i = j + 1 + len;
        }

        return res;
   }
}
