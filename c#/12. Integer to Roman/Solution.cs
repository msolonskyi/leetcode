﻿public class Solution {
    public string IntToRoman(int num) {
        var M = new [] { "", "M", "MM", "MMM" };
        var C = new[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        var X = new[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        var I = new[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        return M[num / 1000] + C[(num % 1000) / 100] + X[num % 100 / 10] + I[num % 10];
    }
}