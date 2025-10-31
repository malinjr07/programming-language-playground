package main

import "fmt"

func loops() {
	i := 1
	for i < 3 {
		fmt.Println("i in Loop that act as while: ", i)
		i++
	}

	for j := i; j < 8; j++ {
		fmt.Println("i in for Loop: ", j)

	}

	for indx, value := range []string{"A", "B", "C"} {
		fmt.Println(indx, value)
	}
}
