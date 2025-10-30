package main

import "fmt"

func operators() {
	a, b := 10, 3

	// Arithmetic
	fmt.Println("Addition: ", a+b)
	fmt.Println("Deduction: ", a-b)
	fmt.Println("Multiplication: ", a*b)
	fmt.Println("Division: ", a/b)
	fmt.Println("Modulus: ", a%b)

	// Comparison
	fmt.Println("Equal: ", a == b)
	fmt.Println("Not Equal: ", a != b)
	fmt.Println("Less Than: ", a > b)
	fmt.Println("Greater Than: ", a < b)
	fmt.Println("Less Than or Equal: ", a <= b)
	fmt.Println("Greater Than or Equal: ", a >= b)

	// Unary
	a++
	fmt.Println("Only Post Increment: ", a)
	b--
	fmt.Println("Only Post Increment: ", b)

	x, y := true, false
	// Logical Operator
	fmt.Println("Logical And: ", x && y)
	fmt.Println("Logical OR: ", x || y)
	fmt.Println("Logical Not: ", !x)

	// Bitwise Operator
	fmt.Println("Bitwise And: ", a&b)
	fmt.Println("Bitwise Or: ", a|b)
	fmt.Println("Bitwise XOr: ", a^b)
	fmt.Println("Bitwise Left Shift: ", a>>1)
	fmt.Println("Bitwise Right Shift: ", b<<1)

	// Assignment
	a += 5
	b *= 3
	fmt.Println("Assignments: ", a, b)
}
