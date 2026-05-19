public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // Second solution with bitmask
        var rows = new int[9];
        var cols = new int[9];
        var squares = new int[9];

        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                if (board[r][c] == '.') continue;

                var squareIndex = (r / 3) * 3 + (c / 3);

                var curr = board[r][c] - '1';
                var mask = 1 << curr;

                if ((rows[r] & mask) > 0 ||
                    (cols[c] & mask) > 0 ||
                    (squares[squareIndex] & mask) > 0) return false;

                rows[r] |= mask;
                cols[c] |= mask;
                squares[squareIndex] |= mask;
            }
        }

        return true;
    }
}
