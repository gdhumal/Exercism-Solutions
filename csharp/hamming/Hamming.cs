using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length) 
            throw new ArgumentException();

        int distance = 0;
        for (int index = 0, length = firstStrand.Length; index < length; index++)
        {
            if (firstStrand[index] != secondStrand[index])
                distance++;
        }
        return distance;
    }
}