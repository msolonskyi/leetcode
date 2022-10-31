public class Solution {
    public int SubarrayGCD(int[] nums, int k)
    {
        var cnt = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            var currGcd = 0;
            for (var j = i; j < nums.Length; j++)
            {
                currGcd = gcd(currGcd, nums[j]);
                if (currGcd == k)
                    cnt++;
            }
        }
        return cnt;
    }
    private int gcd(int a, int b)
    {
        return b == 0 ? a : gcd(b, a % b);
    }
}