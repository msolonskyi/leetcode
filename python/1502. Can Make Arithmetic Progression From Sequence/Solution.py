class Solution:
    def canMakeArithmeticProgression(self, arr: List[int]) -> bool:
        arr.sort()
        return all(i - j == arr[0] - arr[1] for i, j in zip(arr, arr[1:]))