/*
https://leetcode.com/problems/ransom-note/description/
*/
package main

import (
	"fmt"
)

// Input
var ransomNote = "ab"
var magazine = "aa"

func main() {
	fmt.Println(canConstruct(ransomNote, magazine))
}

func canConstruct(ransomNote string, magazine string) bool {
	if len(magazine) < len(ransomNote) {
		return false
	}

	resources := make(map[rune]int)

	for _, r := range magazine {
		resources[r] += 1
	}

	for _, r := range ransomNote {
		if resources[r] == 0 {
			return false
		} else {
			resources[r] -= 1
		}
	}
	return true
}
