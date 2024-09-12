/*
https://leetcode.com/problems/running-sum-of-1d-array/description/
*/
package main

import (
	"flag"
	"fmt"
	"strconv"
)

func main() {
	// Parse the command line arguments
	flag.Parse()
	args := flag.Args()
	nums := make([]int, len(args))
	for i, v := range args {
		num, _ := strconv.Atoi(v)
		nums[i] = num
	}

	fmt.Println(runningSum(nums))
}

func runningSum(nums []int) []int {
	result := make([]int, len(nums))
	for i, v := range nums {
		if i == 0 {
			result[i] = v
		} else {
			result[i] = v + result[i-1]
		}
	}
	return result
}
