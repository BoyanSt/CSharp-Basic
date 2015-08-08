using System;
using System.Collections.Generic;
using System.Linq;



class LongestWordText
{
    static void Main()
    {
        string text = Console.ReadLine();
        string[] wordsText = text.Split(new char[]{' ','.',','},StringSplitOptions.RemoveEmptyEntries);

        int maxLength = int.MinValue;

        for (int i = 0; i < wordsText.Length; i++)
        {
            int length = wordsText[i].Length;
            if (length>maxLength)
            {
                maxLength = length;
            }
        }
        foreach (var world in wordsText)
        {
            if (world.Length==maxLength)
            {
                Console.WriteLine(world);
            }
        }
    }
}

