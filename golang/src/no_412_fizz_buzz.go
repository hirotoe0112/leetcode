/*
https://leetcode.com/problems/fizz-buzz/description/
*/
package main

import (
	"fmt"
	"strconv"
)

// Input
var n = 17

func main() {
	fmt.Println(fizzBuzz(17))
}

func fizzBuzz(n int) []string {
	fizzbuzz := make([]string, n)
	for i := 1; i <= n; i++ {
		if i%3 == 0 && i%5 == 0 {
			fizzbuzz[i-1] = "FizzBuzz"
		} else if i%3 == 0 {
			fizzbuzz[i-1] = "Fizz"
		} else if i%5 == 0 {
			fizzbuzz[i-1] = "Buzz"
		} else {
			fizzbuzz[i-1] = strconv.Itoa(i)
		}
	}
	return fizzbuzz
}
