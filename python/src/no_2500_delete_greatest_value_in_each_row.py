from typing import List


class Solution:
    def deleteGreatestValue(self, grid: List[List[int]]) -> int:
        result = 0
        row_size = len(grid)
        element_size = len(grid[0])
        for i in range(row_size):
            grid[i].sort()
        for i in range(element_size):
            current_list = []
            for j in range(row_size):
                current_list.append(grid[j].pop())
            result += max(current_list)
        return result


solution = Solution()
print(solution.deleteGreatestValue(grid=[[1, 2, 4], [3, 3, 1]]))
