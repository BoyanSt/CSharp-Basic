using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger tri1 = BigInteger.Parse(Console.ReadLine());
        BigInteger tri2 = BigInteger.Parse(Console.ReadLine());
        BigInteger tri3 = BigInteger.Parse(Console.ReadLine());
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        BigInteger tri4 = 0;
        if (n == 1)
        {
            tri4 = tri1;
        }
        if (n == 2)
        {
            tri4 = tri2;
        }
        if (n == 3)
        {
            tri4 = tri3;
        }
        if (n > 3)
        {
            for (int i = 0; i < n - 3; i++)
            {
                tri4 = tri3 + tri2 + tri1;
                tri1 = tri2;
                tri2 = tri3;
                tri3 = tri4;
            }
        }

        Console.WriteLine(tri4);
    }
}

