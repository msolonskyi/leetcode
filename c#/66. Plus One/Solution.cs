public class Solution {
    public int[] PlusOne(int[] digits) {
        digits[digits.Length - 1] += 1;
        var tens = 0;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            var r = tens + digits[i];
            if (r >= 10)
            {
                digits[i] = r - 10;
                tens = 1;
            }
            else
            {
                digits[i] = r;
                tens = 0;
            }
        }

        if (tens == 0)
            return digits;

        int[] combined = new int[digits.Length + 1];
        Array.Copy(new[] { tens }, combined, 1);
        Array.Copy(digits, 0, combined, 1, digits.Length);

        return combined;
    }
}