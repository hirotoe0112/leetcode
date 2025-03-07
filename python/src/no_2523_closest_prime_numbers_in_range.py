from typing import List


# Sieve of Eratosthenes
# https://cp-algorithms.com/algebra/sieve-of-eratosthenes.html
class Solution2:
    def closestPrimes(self, left: int, right: int) -> List[int]:
        # early return
        if right <= 2:
            return [-1, -1]
        # First, we need to find all prime numbers in the range left to right.

        # Initialize array with True values
        is_prime = [True] * (right + 1)
        # 0 and 1 are not prime numbers
        is_prime[0] = False
        is_prime[1] = False
        # mark as False for i and all multiples of i
        for i in range(2, right + 1):
            # All numbers less than i * i are already marked, so we can start from i * i
            for j in range(i * i, right + 1, i):
                is_prime[j] = False

        # Second, we need to find the closest pair of prime numbers.
        # Same as the Solution class
        primes = []
        minimum_diff = 1000000
        num1 = -1
        num2 = -1
        for i in range(left, right + 1):
            if is_prime[i]:
                primes.append(i)
                if len(primes) > 1:
                    diff = primes[-1] - primes[-2]
                    if diff < minimum_diff:
                        minimum_diff = diff
                        num1 = primes[-2]
                        num2 = primes[-1]
        return [num1, num2]


# Time Exceeded
class Solution:
    def closestPrimes(self, left: int, right: int) -> List[int]:
        primes = []
        minimum_diff = 1000000
        num1 = -1
        num2 = -1
        for i in range(left, right + 1):
            if self.isPrimeNumber(i):
                primes.append(i)
                if len(primes) > 1:
                    diff = primes[-1] - primes[-2]
                    if diff < minimum_diff:
                        minimum_diff = diff
                        num1 = primes[-2]
                        num2 = primes[-1]
        return [num1, num2]

    def isPrimeNumber(self, num: int) -> bool:
        if num == 0 or num == 1:
            return False
        for i in range(2, num):
            if num % i == 0:
                return False
        return True


left = 10
right = 19
solution = Solution2()
print(solution.closestPrimes(left=left, right=right))
