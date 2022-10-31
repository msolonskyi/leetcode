public class Solution {
    public int MaxLength(IList<string> arr)
    {
        var dp = new List<int> { 0 };
        var res = 0;
        foreach (var s in arr)
        {
            var a = 0;
            var dup = 0;
            foreach (var c in s.ToCharArray())
            {
                dup |= a & (1 << (c - 'a'));
                a |= 1 << (c - 'a');
            }
            if (dup > 0)
                continue;
            for (var i = dp.Count - 1; i >= 0; --i)
            {
                if ((dp[i] & a) > 0) continue;
                dp.Add(dp[i] | a);
                res = Math.Max(res, BitCount(dp[i] | a));
            }
        }
        return res;
    }
    public static int BitCount(int n)
    {
        var count = 0;
        while (n != 0)
        {
            count++;
            n &= n - 1;
        }
        return count;
    }
}