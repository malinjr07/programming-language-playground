// Statically Typed Programming Language

public class DataTypes {
    public static void main(String[] args) {
        // Primitive Data Types
        byte minA = 25; // 8-bit
        short midA = 256; // 16-bit
        int a = 20; // 32-bit
        long l = 254l; // 64-bit
        float b = 2.54f; // 32-bit
        double d = 25.54; // 64-bit
        char c = 'A'; // 16-bit
        boolean flag = true;

        System.err.println("byte minA: " + minA);
        System.err.println("short midA: " + midA);
        System.out.println("int a: " + a);
        System.out.println("float b: " + b);
        System.out.println("double d: " + d);
        System.out.println("long l: " + l);
        System.out.println("char c: " + c);
        System.out.println("boolean flag: " + flag);

        // Reference Data type
        String str = "New String";
        int[] intArr = { 1, 5, 2 };

        String lng = null;

        System.err.println("str :" + str);
        System.err.println("intArr: " + intArr);
        System.err.println("null lng: " + lng);

    }
}