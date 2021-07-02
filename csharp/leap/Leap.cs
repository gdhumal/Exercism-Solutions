using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool isItDivisibleBy4 = year % 4 == 0,  isItDivisibleBy100 = year % 100 == 0, isItDivisibleBy400 = year % 400 == 0;

        return isItDivisibleBy4 && (!isItDivisibleBy100 || (isItDivisibleBy400));
    }
}