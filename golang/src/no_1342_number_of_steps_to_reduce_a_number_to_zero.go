/*
https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/description/
*/
package main

import (
	"fmt"
)

// Input
var num int = 123

func main() {
	fmt.Println(numberOfSteps(num))
}

func numberOfSteps(num int) int {
	var steps = 0
	for num != 0 {
		if num%2 == 0 {
			num /= 2
		} else {
			num -= 1
		}
		steps++
	}
	return steps
}
