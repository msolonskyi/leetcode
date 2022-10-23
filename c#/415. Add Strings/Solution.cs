using System;

public class Solution {
    public string AddStrings(string num1, string num2) {
        var res = string.Empty;
        var s = 0;
        for (int i = 0; i < Math.Max(num1.Length, num2.Length); i++)
        {
            var r = GetValueByPosition(num1, i) + GetValueByPosition(num2, i) + s;
            if (r >= 10)
            {
                res = Convert.ToString(r - 10) + res;
                s = 1;
            }
            else
            {
                res = Convert.ToString(r) + res;
                s = 0;
            }
        }
         
        return (s == 0 ? "" : Convert.ToString(s)) + res;
    }

    private int GetValueByPosition(string str, int position)
    {
        if (str.Length <= position)
            return 0;
        return Convert.ToInt32(str[str.Length - position - 1].ToString());
    }
}