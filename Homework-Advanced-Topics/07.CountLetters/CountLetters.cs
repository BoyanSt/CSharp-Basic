using System;

class CountLetters
{
    static void Main()
    {
        string sequenceStr = Console.ReadLine();
        string[] sequnceLetters = sequenceStr.Split();

        Array.Sort(sequnceLetters);

        for (int i = 0; i < sequnceLetters.Length; i++)
        {
            int count = 1;
            for (int k = i + 1; k < sequnceLetters.Length; k++)
            {
                if (sequnceLetters[i] == sequnceLetters[k])
                {
                    count++;
                    i++;
                }
            }
            Console.WriteLine("{0} -> {1}", sequnceLetters[i], count);
        }

    }
}

