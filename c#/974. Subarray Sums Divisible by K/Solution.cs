public class Solution {
    public int SubarraysDivByK(int[] nums, int k) {
        int[] output = new int[k];
        var m = 0;
        var res = 0;
        output[0] = 1;
        for (var i = 0; i < nums.Length; i++)
        {
            m = (m + nums[i] % k + k) % k;
            res += output[m];
            output[m]++;
        }
        return res;
    }
}