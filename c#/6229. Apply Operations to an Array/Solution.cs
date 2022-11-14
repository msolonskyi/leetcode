public class Solution {
    public int[] ApplyOperations(int[] nums)
    {
        if (nums.Length < 2)
            return nums;
        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                nums[i] *= 2;
                nums[i + 1] = 0;
            }
        }
        return ShiftZeros(nums);
    }
    public int[] ShiftZeros(int[] nums)
    {
        var res = new int[nums.Length];
        var frontIterator = 0;
        var backIterator = nums.Length - 1;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                res[backIterator] = nums[i];
                backIterator--;
            }
            else
            {
                res[frontIterator] = nums[i];
                frontIterator++;
            }
        }
        return res;
    }
}