using System;


class RemoveNames
{
    static void Main()
    {
        string firstStr = Console.ReadLine();
        string secondStr = Console.ReadLine();

        string[] firstSequence = firstStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] secondSequnce = secondStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < firstSequence.Length; i++)
        {
            for (int k = 0; k < secondSequnce.Length; k++)
            {
                
                if (firstSequence[i] == secondSequnce[k])
                {
                    firstSequence[i] = "";
                }
            }
        }

        foreach (var name in firstSequence)
        {
            if (!(name==""))
            {
                Console.Write(name + " ");
            }
        }
        Console.WriteLine();
    }
}

