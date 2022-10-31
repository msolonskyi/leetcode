public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        if (strs == null || strs.Length == 0)
            return new List<IList<string>>();
        var map = new Dictionary<string, IList<string>>();
        foreach (var s in strs)
        {
            var ca = s.ToCharArray();
            Array.Sort(ca);
            var keyStr = string.Join("", ca.Where(x => x > 0).Select(x => x.ToString()));
            if (!map.ContainsKey(keyStr))
                map.Add(keyStr, new List<string>());
            map[keyStr].Add(s);
        }
        return map.Select(x => x.Value).ToList();
    }
}