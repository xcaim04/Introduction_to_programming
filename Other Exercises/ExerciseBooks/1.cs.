using System;
namespace Fibonacci;

class Fibonacci
{
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());

        int a=1, b=1, tmp;

        for (int i=2;i<=number;i++) // Time Complexity: O(n)
        {
            tmp = b;
            b += a;
            a = tmp;
        }

        Console.WriteLine(b);

    }
}