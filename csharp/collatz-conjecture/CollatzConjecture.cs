using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        int steps = 0;
        CalculateSteps(number, ref steps);
        return steps;
    }

    public static int CalculateSteps(int number, ref int steps)
    {
        if (number < 1)
        {
            throw new ArgumentOutOfRangeException();
        }

        if (number != 1)
        {
            number = number % 2 == 0 ? number / 2 : number * 3 + 1;
            steps++;

            CalculateSteps(number, ref steps);
        }

        return number;
    }
}