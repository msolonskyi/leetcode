class Solution:
    def findNonMinOrMax(self, nums: List[int]) -> int:
        arr = nums[:3]
        if len(arr) < 3:
            return -1
        arr.remove(max(arr))
        arr.remove(min(arr))
        return arr[0]