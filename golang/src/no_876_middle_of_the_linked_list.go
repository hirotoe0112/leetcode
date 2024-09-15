/*
https://leetcode.com/problems/middle-of-the-linked-list/description/
*/
package main

import (
	"fmt"
)

type ListNode struct {
	Val int
	Next *ListNode
}

func main() {
	// 1->2->3->4->5
	head := &ListNode{Val: 1}
	head.Next = &ListNode{Val: 2}
	head.Next.Next = &ListNode{Val: 3}
	head.Next.Next.Next = &ListNode{Val: 4}
	head.Next.Next.Next.Next = &ListNode{Val: 5}

	fmt.Println(middleNode2(head))
}

func middleNode2(head *ListNode) *ListNode {
	middleNode := head
	counter := 0
	for head != nil {
		counter++
		head = head.Next
		if head != nil && counter % 2 != 0 {
			middleNode = middleNode.Next
		}
	}
	return middleNode
}

func middleNode(head *ListNode) *ListNode {
	array := make([]*ListNode, 0)
	length := 0

	for head != nil {
		array = append(array, head)
		head = head.Next
		length++
	}

	return array[length / 2]
}