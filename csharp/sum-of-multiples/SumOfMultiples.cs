using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        var multiplesWithOutZero = multiples.Where(x => x != 0);
        return Enumerable.Range(0, max).Where(i => multiplesWithOutZero.Any(m => i % m == 0)).Sum();
    }
}