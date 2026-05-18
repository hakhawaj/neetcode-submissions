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
        var lengthSb = new StringBuilder();

        while (i < s.Length)
        {
            char c = s[i];
            if (c == '#')
            {
                int len = int.Parse(lengthSb.ToString());
                res.Add(s.Substring(i + 1, len));
                i = i + 1 + len;
                lengthSb.Clear();
            }
            else
            {
                lengthSb.Append(c);
                i++;
            }
        }

        return res;
   }
}
