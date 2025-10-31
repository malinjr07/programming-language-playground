package main

import "fmt"

func conditions() {
	a, b := 15, 35

	if a < b {
		fmt.Println("A is less than B")
	} else if a == b {
		fmt.Println("A is equal to B")
	} else {
		fmt.Println("A is greater than B")
	}

	switch a {
	case (b / 7) * 3:
		fmt.Println("A is equal to B")
	default:
		fmt.Println("Unknown")
	}
}
