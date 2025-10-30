fn main() {
    let mut a = 10;
    let mut b = 3;

    // Arithmetic
    println!("{}", a + b);
    println!("{}", a - b);
    println!("{}", a * b);
    println!("{}", a / b);
    println!("{}", a % b);

    // Comparison
    println!("{}", a == b);
    println!("{}", a != b);
    println!("{}", a > b);
    println!("{}", a < b);
    println!("{}", a >= b);
    println!("{}", a <= b);

    // Logical
    let (x, y) = (true, false);
    println!("{}", x && y);
    println!("{}", x || y);
    println!("{}", !x);

    // Bitwise
    println!("{}", a & b);
    println!("{}", a | b);
    println!("{}", a ^ b);
    println!("{}", a << 1);
    println!("{}", a >> 1);

    // Assignment
    a += 5;
    b *= 2;
    println!("{}, {}", a, b);

    // Ternary-like
    println!("{}", if a > b { "A greater" } else { "B greater" });
}
