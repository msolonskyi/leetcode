public class Solution {
    public long MakeSimilar(int[] nums, int[] target)
    {
        Array.Sort(nums);
        Array.Sort(target);
        var oA = new List<int>();
        var eA = new List<int>();
        var oB = new List<int>();
        var eB = new List<int>();
        foreach (var x in nums)
        {
            if (x % 2 == 1) oA.Add(x);
            else eA.Add(x);
        }
        foreach (var x in target)
        {
            if (x % 2 == 1) oB.Add(x);
            else eB.Add(x);
        }
        var ans = 0L;
        for (int i = 0; i < oA.Count(); i++)
            if (oA[i] > oB[i])
                ans += (oA[i] - oB[i]) / 2;
        for (int i = 0; i < eA.Count(); i++)
            if (eA[i] > eB[i])
                ans += (eA[i] - eB[i]) / 2;
        return ans;
    }
}