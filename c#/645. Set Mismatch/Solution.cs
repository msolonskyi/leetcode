public class Solution {
    public int[] FindErrorNums(int[] nums) {
        long n = Convert.ToInt64(nums.Length);
        long s = nums.Sum(x => Convert.ToInt64(x));
        int a = Convert.ToInt32(n * (n + 1) / 2 - s);
        long s2 = nums.Sum(x => Convert.ToInt64(x * x));
        long nn = n * (n + 1) * (2 * n + 1) / 6;
        int b = Convert.ToInt32(nn - s2);
        return new[] { (b - a * a) / (2 * a), (b + a * a) / (2 * a) };
    }
}