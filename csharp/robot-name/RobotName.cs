using System;
using System.Collections.Generic;
using System.Linq;

public class Robot
{
    private static readonly HashSet<string> robots = new HashSet<string>();
    private static Random random = new Random();
    private const string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public string Name { get; private set; } = CreateName();

    public void Reset()
    {
        robots.Remove(Name);
        Name = CreateName();
    }

    private static string CreateName()
    {
        string currentName = string.Empty;
        
        do
        {
            currentName = new string(Enumerable.Repeat(Letters, 2).Select(s => s[random.Next(s.Length)]).ToArray()) +
                                           random.Next(0, 999).ToString("000");
        } 
        while (robots.Contains(currentName));

        robots.Add(currentName);

        return currentName;
    }
}