using System;

class Beers
{
    static void Main()
    {
        int stacks = 0;
        int beers = 0;

        do
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }
            string[] inputAsStrArr = input.Split();
            int count = int.Parse(inputAsStrArr[0]);
            string measure = inputAsStrArr[1];

            if (measure == "stacks")
            {
                stacks += count;
            }
            else
            {
                beers += count;
            }

        } while (true);

        if (beers>=20)
        {
            stacks += beers / 20;
            beers %= 20;
        }
        Console.WriteLine("{0} stacks + {1} beers",stacks,beers);
    }
}

