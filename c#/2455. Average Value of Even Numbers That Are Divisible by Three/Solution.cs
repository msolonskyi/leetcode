public class Solution {
    public int AverageValue(int[] nums) {
        var arr = nums.Where(x => x % 2 == 0 && x % 3 == 0).ToArray();
        if (arr.Length == 0)
            arr = new[] { 0 };
        return Convert.ToInt32(Math.Floor(arr.Average(x => x)));
    }
}