public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new Dictionary<int, HashSet<char>>();
        var cols = new Dictionary<int, HashSet<char>>();
        var squares = new Dictionary<(int, int), HashSet<char>>();

        for (int r = 0; r < 9; r++)
        {
            if (!rows.ContainsKey(r)) rows[r] = new HashSet<char>();
            for (int c = 0; c < 9; c++)
            {
                if (!cols.ContainsKey(c)) cols[c] = new HashSet<char>();
                if (!squares.ContainsKey((r/3, c/3))) squares[(r/3, c/3)] = new HashSet<char>();
                
                char curr = board[r][c];
                if (curr == '.') continue;

                if (rows[r].Contains(curr) ||
                    cols[c].Contains(curr) ||
                    squares[(r/3, c/3)].Contains(curr)) return false;

                rows[r].Add(curr);
                cols[c].Add(curr);
                squares[(r/3, c/3)].Add(curr);
            }
        }

        return true;
    }
}
