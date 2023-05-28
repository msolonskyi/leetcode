public class Solution {
    public string RemoveTrailingZeros(string num) {
        var lastNonZeroIndex = num.Length - 1;

        while (lastNonZeroIndex >= 0 && num[lastNonZeroIndex] == '0')
            lastNonZeroIndex--;

        return num.Substring(0, lastNonZeroIndex + 1);
    }
}