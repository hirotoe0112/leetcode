from typing import List


class Solution:
    def removeElement(self, nums: List[int], val: int) -> int:
        slow = 0  # 書き込み位置
        for fast in range(len(nums)):
            if nums[fast] != val:
                nums[slow] = nums[fast]
                slow += 1
        return slow


solution = Solution()
print(solution.removeElement([3, 3, 2, 2, 3], 3))
