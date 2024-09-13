/*
https://leetcode.com/problems/richest-customer-wealth/description/
*/
package main

import (
	"fmt"
)

// Input
var accounts = [][]int{{1, 2, 3}, {4, 5, 6}, {3, 4, 5}}

func main() {
	fmt.Println(maximumWealth(accounts))
}

func maximumWealth(accounts [][]int) int {
	maxWealth := 0
	for _, account := range accounts {
		sum := 0
		for _, amount := range account {
			sum += amount
		}
		if maxWealth < sum {
			maxWealth = sum
		}
	}
	return maxWealth
}
