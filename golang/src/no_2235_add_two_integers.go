/*
https://leetcode.com/problems/add-two-integers/description/
*/

package main

import (
	"fmt"
	"flag"
)

func main() {
	// Parse the command line arguments
	num1 := flag.Int("num1", 0, "First integer")
	num2 := flag.Int("num2", 0, "Second integer")
	flag.Parse()

	fmt.Println(sum(*num1, *num2))
}

func sum(num1 int, num2 int) int {
	return num1 + num2
}