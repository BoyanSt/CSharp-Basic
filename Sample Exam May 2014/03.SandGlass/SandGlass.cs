using System;


class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('*',n));

        for (int i = 0,counter=0; i < n-2; i++)
        {
            Console.WriteLine(new string('.', counter + 1) + new string('*', n - 2 - 2 * counter) + 
                              new string('.', counter + 1));

            if (i<(n-2)/2)
            {
                counter++;
            }
            else
            {
                counter--;
            }
        }

        Console.WriteLine(new string('*', n));
    }
}

