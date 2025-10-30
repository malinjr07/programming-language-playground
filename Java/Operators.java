import static java.lang.System.out;

public class Operators {
    public static void main(String[] args) {
        int a = 6, b = 9;

        // Arithmetic Operators
        out.println("Addition: " + (a + b));
        out.println("Deduction: " + (a - b));
        out.println("Multiplication: " + (a * b));
        out.println("Division: " + (a / b));
        out.println("Modulus: " + (a % b));

        // Comparison
        out.println("Equal: " + (a == b));
        out.println("Not Equal: " + (a != b));
        out.println("Greater Than: " + (a > b));
        out.println("Less Than: " + (a < b));
        out.println("Greater Than Equal: " + (a >= b));
        out.println("Less Than Equal: " + (a <= b));

        // Logical Operator
        boolean x = true, y = false;
        out.println("Logical And: " + (x && y));
        out.println("Logical OR: " + (x || y));
        out.println("Logical Not: " + (!x));

        // Bitwise
        out.println("Bitwise And: " + (a & b));
        out.println("Bitwise Or: " + (a | b));
        out.println("Bitwise XOr: " + (a ^ b));
        out.println("Bitwise Not: " + (~b));
        out.println("Bitwise Left Shift: " + (a << 1));
        out.println("Bitwise Right Shift: " + (a >> 1));

        // Assignment
        a += 5;
        b *= 4;
        out.println("Assignment a: " + a);
        out.println("Assignment b: " + b);
    }
}