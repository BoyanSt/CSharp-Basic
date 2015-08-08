using System;


class LongestAreaArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] str = new string[n];
        int longestArea = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            str[i] = Console.ReadLine();
        }

        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int k = 0; k < n; k++)
            {
                if (str[i] == str[k])
                {
                    count++;
                }
            }
            if (count > longestArea)
            {
                longestArea = count;
            }
            count = 0;
        }
        Console.WriteLine(longestArea);
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int k = 0; k < n; k++)
            {
                if (str[i] == str[k])
                {
                    count++;
                }

            }
            if (count==longestArea)
            {
                for (int m = 0; m < longestArea; m++)
                {
                    Console.WriteLine(str[i]); 
                }
                break;
            }
        }
    }
}