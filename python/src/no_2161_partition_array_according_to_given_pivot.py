from typing import List


class Solution:
    def pivotArray(self, nums: List[int], pivot: int) -> List[int]:
        first = []
        second = []
        center = []
        for i in nums:
            if i < pivot:
                first.append(i)
            elif pivot < i:
                second.append(i)
            else:
                center.append(i)
        return first + center + second


nums = [9, 12, 3, 5, 14, 10, 10]
solution = Solution()
print(solution.pivotArray(nums=nums, pivot=10))
