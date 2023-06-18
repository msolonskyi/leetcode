public class Solution {
    public int EqualPairs(int[][] grid) {
        var n = grid.Length;
        if (n == 1)
            return 1;
        var ls = new List<int[]>();
        for (var i = 0; i < n; i++)
            for (var j = 0; j < n; j++)
                if (grid[i][0] == grid[0][j])
                    ls.Add(new int[]{i, j});

        var deep = 1;
        var rem = new List<int[]>();
        while (deep < n)
        {
            rem = new List<int[]>();
            foreach (var val in ls)
            {
                if (grid[deep][val[1]] != grid[val[0]][deep])
                    rem.Add(val);
            }
            ls = ls.Except(rem).ToList();
            deep += 1;
        }
        return ls.Count();
    }
}