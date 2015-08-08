using System;

class MatrixPal
{
    static void Main()
    {

        int height = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());

        string[,] palidrom = new string[height, width];

        for (int rows = 0; rows < height; rows++)
        {
            for (int cols = 0; cols < width; cols++)
            {
                Console.Write(palidrom[rows, cols] = "" + (char)('a' + rows) +
                                                     (char)('a' + cols + rows) + (char)('a' + rows) + " ");
            }
            Console.WriteLine();
        }
    }
}

