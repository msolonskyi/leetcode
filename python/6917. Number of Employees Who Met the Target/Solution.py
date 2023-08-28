class Solution:
    def numberOfEmployeesWhoMetTarget(self, hours: List[int], target: int) -> int:
        li = [i for i in hours if i >= target]
        return len(li)