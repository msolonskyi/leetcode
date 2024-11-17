class Solution:
    def minProcessingTime(self, processorTime: List[int], tasks: List[int]) -> int:
        n = len(processorTime)
        processorTime.sort(reverse=True)
        tasks.sort(reverse=True)
        total_time = n * [0]

        for i in range(n):
            max_task_time = tasks.pop()
            for thread in range(3):
                max_task_time = max(max_task_time, tasks.pop())
                
            total_time[i] = processorTime[i] + max_task_time

        return max(total_time)