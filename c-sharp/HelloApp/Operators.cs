using System;
class Operators
{
    public static void AllOperators()
    {
        Console.WriteLine("All Operation in a file!");

        int a = 10, b = 3;
        // Arithmetic
        Console.WriteLine($"Addition: {a + b}");
        Console.WriteLine($"Deduction: {a + b}");
        Console.WriteLine($"Multiplication: {a * b}");
        Console.WriteLine($"Division: {a / b}");
        Console.WriteLine($"Modulus: {a % b}");
        // Unary
        Console.WriteLine($"Pre-increment: {++a}");
        Console.WriteLine($"Pre-decrement: {++b}");
        a++;
        Console.WriteLine($"Post-increment: {a}");
        b++;
        Console.WriteLine($"Post-decrement: {b}");

        // Comparison
        Console.WriteLine($"Comparison Equal: {a == b}");
        Console.WriteLine($"Comparison Not Equal: {a != b}");
        Console.WriteLine($"Comparison Less than: {a > b}");
        Console.WriteLine($"Comparison Greater than: {a < b}");
        Console.WriteLine($"Comparison Less than Equal: {a >= b}");
        Console.WriteLine($"Comparison Greater than Equal: {a <= b}");

        // Logical
        bool x = true, y = false;
        Console.WriteLine($"Logical And: {x && y}");
        Console.WriteLine($"Logical Or: {x || y}");
        Console.WriteLine($"Logical Not: {!y}");

        // Bitwise
        Console.WriteLine($"Bitwise And: {a & b}");
        Console.WriteLine($"Bitwise Or: {a | b}");
        Console.WriteLine($"Bitwise XOR: {a ^ b}");
        Console.WriteLine($"Bitwise Not: {~b}");
        Console.WriteLine($"Bitwise Left Shift: {a << 1}");
        Console.WriteLine($"Bitwise Right Shift: {a >> 1}");

        // Assignment
        a += 5; b *= 3;
        Console.WriteLine($"Assignment: {a}");
        Console.WriteLine($"Assignment: {b}");

        // Ternary
        Console.WriteLine(a > b ? "A greater" : "B greater");
    }
}