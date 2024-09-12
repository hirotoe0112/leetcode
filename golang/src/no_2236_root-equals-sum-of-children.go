/*
https://leetcode.com/problems/root-equals-sum-of-children/description/
*/

package main

import (
	"flag"
	"fmt"
)

type TreeNode struct {
	Val int
	// The * placed before a type name indicates a pointer type
	Left  *TreeNode
	Right *TreeNode
}

func main() {
	// Parse the command line arguments
	root := flag.Int("root", 0, "Root integer")
	left := flag.Int("left", 0, "Left child's integer")
	right := flag.Int("right", 0, "Right child's integer")
	flag.Parse()

	// Create the tree
	// The * placed before a variable name dereferences the pointer
	rootNode := TreeNode{*root, &TreeNode{*left, nil, nil}, &TreeNode{*right, nil, nil}}

	fmt.Println(checkTree(&rootNode))
}

/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func checkTree(root *TreeNode) bool {
	return root.Val == root.Left.Val+root.Right.Val
}
