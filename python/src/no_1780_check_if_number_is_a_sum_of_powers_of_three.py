# 要復習
class Solution:
    def checkPowersOfThree(self, n: int) -> bool:
        power = 16
        while n > 0:
            if power < 0:
                return False
            for i in range(power, -1, -1):
                if 3**i < n:
                    n -= 3**i
                    power = i - 1
                    break
                elif 3**i == n:
                    return True
                elif i == 0 and n != 1:
                    return False
        return False


num = 21
solution = Solution()
print(solution.checkPowersOfThree(n=num))
