public class Solution {
    public int MinTime(int n, int[][] edges, IList<bool> hasApple) {
        var result = 0;
        var parentID = new Dictionary<int, int> ();
        var visited = new HashSet<int>();
        foreach (var el in edges)
        {
            if (!parentID.ContainsKey(el[1]))
                parentID.Add(el[1], el[0]);
            else parentID.Add(el[0], el[1]);
        }
        for (var i = 0; i < hasApple.Count; i++) {
            if (hasApple[i]) {
                var position = i;
                while (!visited.Contains(position) && position != 0) {
                    result++;
                    visited.Add(position);
                    position = parentID[position];
                }
            }
        }
        return result * 2;
    }
}