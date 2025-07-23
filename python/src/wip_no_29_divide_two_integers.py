# Time Limit Exceeded
class Solution:
    def divide(self, dividend: int, divisor: int) -> int:
        is_negative = False
        if (dividend < 0 and divisor > 0) or (dividend > 0 and divisor < 0):
            is_negative = True

        quotient = 0
        abs_dividend = abs(dividend)
        abs_divisor = abs(divisor)
        while abs_dividend >= abs_divisor:
            quotient += 1
            abs_dividend -= abs_divisor

        if is_negative:
            quotient = int("-" + str(quotient))

        return quotient


solution = Solution()
print(solution.divide(dividend=-103, divisor=50))
