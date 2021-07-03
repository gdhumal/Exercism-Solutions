using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double calculateDistance = Math.Sqrt(x * x + y * y);
        
        return calculateDistance <= 1 ? 10 : calculateDistance <= 5 ? 5 : calculateDistance <= 10 ? 1 : 0;
    }
}
