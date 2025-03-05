class Solution:
    def coloredCells(self, n: int) -> int:
        return self.coloredCellsHelper(n=n, total=0)

    def coloredCellsHelper(self, n: int, total: int) -> int:
        if n == 1:
            return 1
        elif n == 2:
            return total + 5
        else:
            boundary = 4 + 4 * (n - 2)
            total += boundary
            return self.coloredCellsHelper(n=n - 1, total=total)

class Solution2:
    def coloredCells(self, n: int) -> int:
        # n = 1 : 1
        # n = 2 : 1 + 4
        # n = 3 : 1 + 4 + 8
        # n = 4 : 1 + 4 + 8 + 12
        total = 1
        for i in range(2, n + 1):
            total += 4 * (i - 1)
        return total

num = 3
solution = Solution2()
print(solution.coloredCells(n=num))
