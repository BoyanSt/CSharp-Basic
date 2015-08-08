using System;

class SimpleCalculation
{
    static void Main()
    {
        double pointX = double.Parse(Console.ReadLine());
        double pointY = double.Parse(Console.ReadLine());

        int result = 0;

        if (pointX>0&&pointY>0)
        {
            result = 1;
        }
        if (pointX==0&&pointY!=0)
        {
            result = 5;
        }
        if (pointX<0&&pointY>0)
        {
            result = 2;
        }
        if (pointX<0&&pointY<0)
        {
            result = 3;
        }
        if (pointX>0&&pointY<0)
        {
            result = 4;
        }
        if (pointY==0&&pointX!=0)
        {
            result = 6;
        }
        Console.WriteLine(result);
    }
}

