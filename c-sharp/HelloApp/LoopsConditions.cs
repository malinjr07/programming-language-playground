using System;

class LoopsConditions
{
    public static void allLoops()
    {
        int i = 0;
        while (i < 3)
        {
            Console.WriteLine($"I in while loop: {i}");
            i++;
        }

        do
        {
            Console.WriteLine($"i in Do While: {i}");
            i++;
        } while (i < 7);

        for (int j = 0; j < 15; j++)
        {
            Console.WriteLine($"j in For Loop: {j}");
        }

        foreach (var item in new String[] { "A", "B", "C" })
        {
            Console.WriteLine($"Current element in for each: {item}");
        }
    }
    public static void allConditions()
    {
        int a = 10, b = 5;
        if (a > b)
        {
            Console.WriteLine("A>B");
        }
        else if (a == b * 5)
        {
            Console.WriteLine("A==B");
        }
        else
        {
            Console.WriteLine("A<B");
        }

        switch (a)
        {
            case 5:
                Console.WriteLine("A is Five");
                break;
            default:
                Console.WriteLine("A is Unknown");
                break;
        }
    }
}