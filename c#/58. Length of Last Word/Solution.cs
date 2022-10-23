public class Solution {
    public int LengthOfLastWord(string s) {
        var str = s.TrimEnd();
        var res = string.Empty;
        for (var i = str.Length - 1; i >= 0; i--)
        {
            if (str[i] == ' ')
                break;

            res += str[i];

        }
        return res.Length;
    }
}