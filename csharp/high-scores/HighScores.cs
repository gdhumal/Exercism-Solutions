using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private readonly List<int> scores = new List<int> { };
    public HighScores(List<int> list) => scores = list;

    public List<int> Scores() => scores;

    public int Latest() => scores.Last();

    public int PersonalBest() => scores.Max();

    public List<int> PersonalTopThree() => scores.OrderByDescending(s => s).Take(3).ToList();
}