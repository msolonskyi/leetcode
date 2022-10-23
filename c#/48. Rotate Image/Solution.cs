public class Solution {
    public void Rotate(int[][] matrix) {
        var n = matrix.GetLength(0);
        for (var i = 0; i < n / 2; i++)
        {
            for (var j = i; j < n - i - 1; j++)
            {
                var v = matrix[i][j];
                matrix[i][j] = matrix[n - j - 1][i];
                matrix[n - j - 1][i] = matrix[n - i - 1][n - j - 1];
                matrix[n - i - 1][n - j - 1] = matrix[j][n - i - 1];
                matrix[j][n - i - 1] = v;
            }
        }
    }
}