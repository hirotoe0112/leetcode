from typing import List


class Solution:
    def strStr(self, haystack: str, needle: str) -> int:
        target_len = len(needle)
        result = -1
        for i in range(len(haystack) - target_len + 1):
            if haystack[i : target_len + i] == needle:
                result = i
                break
        return result


solution = Solution()
print(solution.strStr(haystack="abcdef", needle="ef"))
