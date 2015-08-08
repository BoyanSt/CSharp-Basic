using System;


class ByteParty
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        byte[] numbers = new byte[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = byte.Parse(Console.ReadLine());
        }

        do
        {
            string input = Console.ReadLine();

            if (input == "party over")
            {
                foreach (var num in numbers)
                {
                    Console.WriteLine(num);
                }
                break;
            }

            string[] inputAsStrArr = input.Split();
            string command = inputAsStrArr[0];
            byte position = byte.Parse(inputAsStrArr[1]);

            switch (command)
            {
                case "-1":
                    for (int i = 0; i < n; i++)
                    {
                        numbers[i] = (byte)(numbers[i] ^ (1 << position));
                    }
                    break;
                case "1":
                    for (int i = 0; i < n; i++)
                    {
                        numbers[i] = (byte)(numbers[i] | (1 << position));
                    }
                    break;
                case "0":
                    for (int i = 0; i < n; i++)
                    {
                        numbers[i] = (byte)(numbers[i] & ~(1 << position));
                    }
                    break;
            }
        } while (true);
    }
}

