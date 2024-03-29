﻿public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        var total = 0;
        var max = nums[0];
        var min = nums[0];
        var currentMax = 0;
        var currentMin = 0;
        
        foreach(var num in nums)
        {
            total += num;
            
            currentMax = Math.Max(num, currentMax + num);
            currentMin = Math.Min(num, currentMin + num);
            
            max = Math.Max(max, currentMax);
            min = Math.Min(min, currentMin);
        }
    
        return max > 0 ? Math.Max(max, total - min) : max;
    }
}
