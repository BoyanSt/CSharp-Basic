using System;
using System.IO;


class CountingWordInText
{
    static void Main()
    {
        int bufSize = 1024;
        Stream inStream = Console.OpenStandardInput(bufSize);
        Console.SetIn(new StreamReader(inStream, Console.InputEncoding, false, bufSize)); 

        string word = Console.ReadLine();
        string text = Console.ReadLine();
        string[] texrAsWords = text.Split(new char[] { ' ', ',', '.', '/', '"', '(', ')', '@','!' },
                                                      StringSplitOptions.RemoveEmptyEntries);
        int count = 0;

        bool result = false;  
        for (int i = 0; i < texrAsWords.Length; i++)
        {
            result = word.Equals(texrAsWords[i], StringComparison.OrdinalIgnoreCase);
            if (result)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

