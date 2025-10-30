using System;
using System.Numerics;
using System.Collections.Generic;

class DataTypes()
{
    public static void Types()
    {
        Console.WriteLine("Let's checkout all data types of C#");

        sbyte sb = 14;
        byte bt = 18;

        short shrt = 11;
        ushort ushrt = 142;

        int i = 1252;
        uint ui = 635;

        long l = 6416516884;
        ulong ul = 6416516884;

        float flt = 2.45f;
        double dbl = 2.4854;
        decimal dcml = 10.5m;

        bool flag = true;

        char c = 'A';
        string str = "Rizu is my Love!";

        Complex comp = new Complex(2, 3);

        int[] arr = { 2, 8, 4 };

        // List & Dictionary

        var list = new List<string> { "Java", "C#", "Ruby" };


        var dict = new Dictionary<string, int> { { "One", 1 }, { "Two", 2 } };




        Console.WriteLine($"{sb}", $"{bt}", shrt, ushrt, i, ui, l, ul);
        Console.WriteLine(flt + ", " + dbl + ", " + dcml);
        Console.WriteLine(flag);
        Console.WriteLine(c + ", " + str);
        Console.WriteLine(comp);
        Console.WriteLine(arr.Length);
        Console.WriteLine(list.Count);
        Console.WriteLine(dict["Two"]);
    }
}