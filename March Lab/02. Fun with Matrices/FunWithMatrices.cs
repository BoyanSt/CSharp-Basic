using System;
using System.Numerics;

class FunWithMatrices
{
    static void Main()
    {
        double[,] matrix = new double[4, 4];
        double startValue = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());

        matrix[0, 0] = startValue;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (row == 0 && col == 0)
                {
                    continue;
                }

                if (row >= 1 && col == 0)
                {
                    matrix[row, col] = matrix[row - 1, matrix.GetLength(1) - 1] + step;
                    continue;
                }

                matrix[row, col] = matrix[row, col - 1] + step;
            }
        }

        do
        {
            string input = Console.ReadLine();
            if (input == "Game Over!")
            {
                break;
            }
            string[] inputAsStrArr = input.Split();

            byte row = byte.Parse(inputAsStrArr[0]);
            byte col = byte.Parse(inputAsStrArr[1]);
            string command = inputAsStrArr[2];
            double number = double.Parse(inputAsStrArr[3]);

            if (command=="multiply")
            {
                matrix[row, col] *= number;
            }

            if (command=="sum")
            {
                matrix[row, col] += number;
            }
            if (command=="power")
            {
                matrix[row, col] = Math.Pow(matrix[row, col], number);
            }

        } while (true);

        double sumMax = double.MinValue;
        double sumLeftDiagon = 0;
        string result = null;
        int resultRowCol = 0;

        for (int row = 0; row < 4; row++)
        {
            double sumRow = 0;

            for (int col = 0; col < 4; col++)
            {
                sumRow += matrix[row, col];              
                if (row==col)
                {
                    sumLeftDiagon += matrix[row, col];
                }
            }
            if (sumRow>sumMax)
            {
                sumMax = sumRow;
                resultRowCol = row;
                result = "ROW";
            }
        }

        for (int row = 0; row < 4; row++)
        {
            double sumCol = 0;

            for (int col = 0; col < 4; col++)
            {
                sumCol += matrix[col, row];
            }

            if (sumCol > sumMax)
            {
                sumMax = sumCol;
                resultRowCol = row;
                result = "COL";
            }
        }

        if (sumLeftDiagon > sumMax)
        {
            sumMax = sumLeftDiagon;
            result = "LEFT-DIAGONAL";
        }

        double sumRightDiagonal = 0;

        for (int row = 3; row >=0; row--)
        {            
            for (int col = 0; col < 4; col++)
            {
                if (row==col)
                {
                    sumRightDiagonal += matrix[row, col];
                }
            }
        }

        if (sumRightDiagonal>sumMax)
        {
            sumMax = sumRightDiagonal;
            result = "RIGHT-DIAGONAL";
        }

        if (result=="ROW")
        {
            Console.WriteLine("ROW[{0}] = {1:F2}",resultRowCol,sumMax);
        }
        if (result=="COL")
        {
            Console.WriteLine("COLUMN[{0}] = {1:F2}", resultRowCol, sumMax);
        }
        if (result=="LEFT-DIAGONAL")
        {
            Console.WriteLine("LEFT-DIAGONAL = {0:F2}",sumMax);
        }
        if (result=="RIGHT-DIAGONAL")
        {
            Console.WriteLine("RIGHT-DIAGONAL = {0:F2}",sumMax);
        }

        //for (int row = 0; row < 4; row++)
        //{
        //    for (int col = 0; col < 4; col++)
        //    {
        //        Console.Write(matrix[row, col] + " ");
        //    }
        //    Console.WriteLine();
        //}
    }
}

