using System;
using System.Collections.Generic;
using System.Linq;



class JoinLists
{
    static void Main()
    {
        string firstStr = Console.ReadLine();
        string secondStr = Console.ReadLine();

        string firstSecondStr = firstStr + " " + secondStr;
        string[] sequnceNumbers = firstSecondStr.Split();


        for (int i = 0; i < sequnceNumbers.Length; i++)
        {
            for (int k = 0; k < sequnceNumbers.Length&&k!=i; k++)
            {
                if (sequnceNumbers[i]==sequnceNumbers[k])
                {
                    sequnceNumbers[i] = "";
                }
            }
        }
        List<string> sequnceAsList = new List<string>(sequnceNumbers);
        sequnceAsList.RemoveAll(str => string.IsNullOrEmpty(str));

        sequnceNumbers = sequnceAsList.ToArray();

        int[] sequnceAsInt = new int[sequnceNumbers.Length];

        for (int i = 0; i < sequnceAsInt.Length; i++)
        {
           sequnceAsInt[i] = int.Parse(sequnceNumbers[i]);
        }
        Array.Sort(sequnceAsInt);

        foreach (var num in sequnceAsInt)
        {
            Console.Write(num +" ");
        }
        Console.WriteLine();
    }
}

