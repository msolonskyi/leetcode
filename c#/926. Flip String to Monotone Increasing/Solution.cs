public class Solution {
    public int MinFlipsMonoIncr(string s) {
        var ones = 0;
        var ans = 0;
        foreach (var num in s)
        {
            if (num == '1')
                ones += 1;
            else
            {
                if (ones > 0)
                {
                    ones -= 1;
                    ans += 1;
                }
            }
        }
        return ans;
    }
}
