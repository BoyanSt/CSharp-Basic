using System;
using System.Collections.Generic;
using System.Linq;



class AverageLoadTimeCalculator
{
    static void Main()
    {
        while (true)
        {
            string textLine = Console.ReadLine();
            Dictionary<string, double> linkLoadTime = new Dictionary<string, double> { };
            Dictionary<string, int> count = new Dictionary<string, int> { };


            while (textLine != string.Empty)
            {
                string[] separatedText = textLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string link = separatedText[2];
                double loadTime = double.Parse(separatedText[3]);

                if (!linkLoadTime.Keys.Contains(link))
                {
                    linkLoadTime[link] = loadTime;
                    count[link] = 1;
                }
                else
                {
                    linkLoadTime[link] = linkLoadTime[link] + loadTime;
                    count[link]++;
                }

                textLine = Console.ReadLine();
            }
            foreach (string link in linkLoadTime.Keys)
            {
                Console.WriteLine(link + " -> " + linkLoadTime[link]/count[link]);
            }

        }

    }
}

