using System;



class CountNames
{
    static void Main()
    {
        string names = Console.ReadLine();
        string[] sequenceNames = names.Split();

        Array.Sort(sequenceNames);

        for (int i = 0; i < sequenceNames.Length; i++)
        {
            int count = 1;
            for (int k = i+1; k < sequenceNames.Length; k++)
            {
                if (sequenceNames[i]==sequenceNames[k])
                {
                    count++;
                    i++;
                }
            }
            Console.WriteLine("{0} -> {1}", sequenceNames[i],count);  
        }
    }
}

