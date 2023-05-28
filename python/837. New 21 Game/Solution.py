class Solution:
    def new21Game(self, n: int, k: int, maxPts: int) -> float:
        ans = [0] * k + [1] * (n - k + 1) + [0] * maxPts
        val = sum(ans[k : k + maxPts])
        for i in reversed(range(k)): 
            ans[i] = val / maxPts
            val += ans[i] - ans[i + maxPts]
        return ans[0]