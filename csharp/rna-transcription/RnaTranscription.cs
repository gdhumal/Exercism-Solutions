using System.Linq;
using System.Collections.Generic;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        // Validate
        if (string.IsNullOrWhiteSpace(nucleotide))
            return nucleotide;

        Dictionary<char, char> dnaToRnaTransform = new Dictionary<char, char>() {
            {'G', 'C'},
            {'C', 'G'},
            {'T', 'A'},
            {'A', 'U'},
        };

        // Replace
        return new string(nucleotide.Select(x => dnaToRnaTransform.ContainsKey(x) ? dnaToRnaTransform.GetValueOrDefault(x) : ' ').ToArray());
    }
}