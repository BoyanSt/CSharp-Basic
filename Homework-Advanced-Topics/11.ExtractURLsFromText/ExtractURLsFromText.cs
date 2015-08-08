using System;


class ExtractURLsFromText
{
    static void Main()
    {
        string text = Console.ReadLine();

        string[] wordsText = text.Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < wordsText.Length; i++)
        {
            if (wordsText[i].Length >= 7)
            {
                string first7symbols = wordsText[i].Substring(0, 7);
                string first4symbols = wordsText[i].Substring(0, 4); 
                if (first7symbols == "http://" || first4symbols == "www.")
                {
                    Console.WriteLine(wordsText[i]); 
                }
            }
        }
    }
}

