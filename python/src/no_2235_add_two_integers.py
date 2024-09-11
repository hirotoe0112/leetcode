import sys

class Solution:
    def sum(self, num1: int, num2: int) -> int:
        return num1 + num2

# Parse the command line arguments
num1 = int(sys.argv[1])
num2 = int(sys.argv[2])
solution = Solution()
print(solution.sum(num1, num2))