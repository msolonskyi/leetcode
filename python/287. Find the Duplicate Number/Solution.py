class Solution:
    def findDuplicate(self, nums: List[int]) -> int:
        arr = [0] * (len(nums) + 1)
        for i in nums:
            arr[i] += 1
            if arr[i] > 1:
                return i 