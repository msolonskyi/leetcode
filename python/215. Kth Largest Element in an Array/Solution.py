class Solution:
    def findKthLargest(self, nums: List[int], k: int) -> int:
        d = {}
        for v in nums:
            if v in d:
                d[v] += 1
            else:
                d[v] = 1
        v = 0
        for i in range(max(d, key=int) + 1, min(d, key=int) - 1, -1):
            if i in d:
                v += d[i]
                if v >= k:
                    return i
            else:
                continue

        return -1