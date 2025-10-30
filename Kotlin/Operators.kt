fun main() {
    var a = 10
    var b = 3

    // Arithmetic
    println(a + b)
    println(a - b)
    println(a * b)
    println(a / b)
    println(a % b)

    // Comparison
    println(a == b)
    println(a != b)
    println(a > b)
    println(a < b)
    println(a >= b)
    println(a <= b)

    // Logical
    val x = true
    val y = false
    println(x && y)
    println(x || y)
    println(!x)

    // Bitwise
    println(a and b)
    println(a or b)
    println(a xor b)
    println(a shl 1)
    println(a shr 1)

    // Assignment
    a += 5
    b *= 2
    println("$a, $b")

    // Ternary equivalent
    println(if (a > b) "A greater" else "B greater")
}
