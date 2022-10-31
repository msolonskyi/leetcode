public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        if (nums.Length < 2 || k == 0)
            return false;
        var map = new Dictionary<int, int> { { 0, -1 } };
        var runningSum = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            runningSum += nums[i];
            runningSum %= k;
            if (map.TryGetValue(runningSum, out var prev))
            {
                if (i - prev > 1) return true;
            }
            else map.Add(runningSum, i);
        }
        return false;
    }
}