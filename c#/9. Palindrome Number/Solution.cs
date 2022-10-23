public class Solution {
    public bool IsPalindrome(int x) {
        var s = x.ToString();
        for (var i = 0; i < Convert.ToInt32(Math.Ceiling(s.Length / 2.0)); i++)
        {
            if (s[i] != s[s.Length - i - 1])
                return false;
        }
        return true; 
    }
}