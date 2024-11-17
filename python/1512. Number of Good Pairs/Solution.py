class Solution:
    def numIdenticalPairs(self, nums: List[int]) -> int:
        return sum((v * (v - 1)) // 2 for k,v in Counter(nums).items() if v > 1)