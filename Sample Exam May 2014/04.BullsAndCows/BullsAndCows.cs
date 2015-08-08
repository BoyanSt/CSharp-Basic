using System;

class BullsAndCows
{
    static void Main()
    {
        int secretNumber = int.Parse(Console.ReadLine());


        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());

        bool solution = false;


        for (int digit1 = 1; digit1 <= 9; digit1++)
        {
            for (int digit2 = 1; digit2 <= 9; digit2++)
            {
                for (int digit3 = 1; digit3 <= 9; digit3++)
                {
                    for (int digit4 = 1; digit4 <= 9; digit4++)
                    {
                        int secretDigit1 = (secretNumber / 1000) % 10;
                        int secretDigit2 = (secretNumber / 100) % 10;
                        int secretDigit3 = (secretNumber / 10) % 10;
                        int secretDigit4 = (secretNumber / 1) % 10;

                        int counterBulls = 0;
                        int counterCows = 0;

                        int oldD1 = digit1;
                        int oldD2 = digit2;
                        int oldD3 = digit3;
                        int oldD4 = digit4;

                        if (digit1 == secretDigit1)
                        {
                            counterBulls++;
                            secretDigit1 = -1;
                            digit1 = -2;
                        }
                        if (digit2 == secretDigit2)
                        {
                            counterBulls++;
                            secretDigit2 = -1;
                            digit2 = -2;
                        }
                        if (digit3 == secretDigit3)
                        {
                            counterBulls++;
                            secretDigit3 = -1;
                            digit3 = -2;
                        }
                        if (digit4 == secretDigit4)
                        {
                            counterBulls++;
                            secretDigit4 = -1;
                            digit4 = -2;
                        }

                        //Count cows

                        if (digit1 == secretDigit2)
                        {
                            counterCows++;
                            secretDigit2 = -1;
                        }
                        else if (digit1 == secretDigit3)
                        {
                            counterCows++;
                            secretDigit3 = -1;
                        }
                        else if (digit1 == secretDigit4)
                        {
                            counterCows++;
                            secretDigit4 = -1;
                        }

                        if (digit2 == secretDigit1)
                        {
                            counterCows++;
                            secretDigit1 = -1;
                        }
                        else if (digit2 == secretDigit3)
                        {
                            counterCows++;
                            secretDigit3 = -1;
                        }
                        else if (digit2 == secretDigit4)
                        {
                            counterCows++;
                            secretDigit4 = -1;
                        }

                        if (digit3 == secretDigit1)
                        {
                            counterCows++;
                            secretDigit1 = -1;
                        }
                        else if (digit3 == secretDigit2)
                        {
                            counterCows++;
                            secretDigit2 = -1;
                        }
                        else if (digit3 == secretDigit4)
                        {
                            counterCows++;
                            secretDigit4 = -1;
                        }

                        if (digit4 == secretDigit1)
                        {
                            counterCows++;
                            secretDigit1 = -1;
                        }
                        else if (digit4 == secretDigit2)
                        {
                            counterCows++;
                            secretDigit2 = -1;
                        }
                        else if (digit4 == secretDigit3)
                        {
                            counterCows++;
                            secretDigit3 = -1;
                        }

                        digit1 = oldD1;
                        digit2 = oldD2;
                        digit3 = oldD3;
                        digit4 = oldD4;

                        if (counterBulls == bulls && counterCows == cows)
                        {

                            if (solution)
                            {
                                Console.Write(" ");
                            }
                            Console.Write("" + digit1 + digit2 + digit3 + digit4);
                            solution = true;
                        }
                    }
                }
            }
        }
        if (!solution)
        {
            Console.WriteLine("No");
        }
    }
}

