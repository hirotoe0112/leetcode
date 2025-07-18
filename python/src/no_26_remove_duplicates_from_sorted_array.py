from typing import List


# Two Pointersパターン
# 配列がソートされている場合に使える
# slow=書き込み位置、fast=読み取り位置
# fastのインデックスでslowの値と比較し、同じ（すでに書き込んである）場合はスキップ、違う（ユニークな値が現れた）場合はslowのインデックスを進めて書き込む
# 値を書き込んだのはslowのインデックスのところまでなので、インデックス+1までがユニークな値がある範囲
# https://www.geeksforgeeks.org/dsa/two-pointers-technique/
class Solution2:
    def removeDuplicates(self, nums: List[int]) -> int:
        slow = 0  # 書き込み位置
        for fast in range(1, len(nums)):
            if nums[slow] != nums[fast]:
                slow += 1
                nums[slow] = nums[fast]
        return slow + 1


# ↓制約を満たしていない
class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        appeared = set()
        for i in range(len(nums)):
            if nums[i] not in appeared:
                appeared.add(nums[i])
            else:
                nums[i] = 101
        nums.sort()
        return len(appeared)


solution = Solution()
print(solution.removeDuplicates(nums=[0, 0, 1, 1, 1, 2, 2, 3, 3, 4]))
