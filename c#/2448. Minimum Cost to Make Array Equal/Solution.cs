public class Solution {
    public long MinCost(int[] nums, int[] cost)
    {
        var left = 1L;
        var right = 1000000L;
        foreach (var num in nums)
        {
            left = Math.Min(num, left);
            right = Math.Max(num, right);
        }
        var ans = findCost(nums, cost, 1);
        while (left < right)
        {
            var mid = (left + right) / 2;
            var y1 = findCost(nums, cost, mid);
            var y2 = findCost(nums, cost, mid + 1);
            ans = Math.Min(y1, y2);
            if (y1 < y2)
                right = mid;
            else
                left = mid + 1;
        }
        return ans;
    }
    private long findCost(int[] nums, int[] cost, long x)
    {
        var res = 0L;
        for (var i = 0; i < nums.Length; i++)
        {
            res += Math.Abs(nums[i] - x) * cost[i];
        }
        return res;
    }
}