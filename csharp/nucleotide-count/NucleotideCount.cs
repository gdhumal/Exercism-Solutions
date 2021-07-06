using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        string nucleoids = "ACGT";
        Dictionary<char, int> dictNucleoids = new Dictionary<char, int>();

        if (new Regex("[^ACGT]").IsMatch(sequence))
            throw new ArgumentException("");

        foreach (var item in nucleoids)
        {
            var count = sequence.Where(x => x == item).Count();
            dictNucleoids.Add(item, count);
        }

        return dictNucleoids;
    }
}