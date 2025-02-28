class Solution:
    def lengthOfLastWord(self, s: str) -> int:
        words = s.split(" ")
        target_words = []
        for word in words:
            if word != "":
                target_words.append(word)
        counter = 0
        for _ in target_words[-1]:
            counter += 1
        return counter

    def solution2(self, s: str) -> int:
        # strip -> https://docs.python.org/3/library/stdtypes.html#str.strip
        words = s.strip().split(" ")
        return len(words[-1])


# Parse the command line arguments
sentence = "   fly me   to   the moon  "
solution = Solution()
print(solution.lengthOfLastWord(s=sentence))
print(solution.solution2(s=sentence))
