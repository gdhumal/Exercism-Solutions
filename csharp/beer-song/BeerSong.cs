using System;
using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        StringBuilder beerSong = new StringBuilder();
        int remainingBottles = startBottles;

        for (int index = 1; index <= takeDown; index++)
        {
            if (index > 1)
            {
                beerSong.Append("\n\n");
            }

            if (remainingBottles == 0)
            {
                beerSong.Append("No more bottles of beer on the wall, no more bottles of beer.\n");
                beerSong.Append($"Go to the store and buy some more, 99 bottles of beer on the wall.");
            }
            if (remainingBottles == 1)
            {
                beerSong.Append($"{remainingBottles} bottle of beer on the wall, {remainingBottles} bottle of beer.\n");
                beerSong.Append($"Take it down and pass it around, no more bottles of beer on the wall.");
            }
            else if(remainingBottles > 1)
            {
                beerSong.Append($"{remainingBottles} bottles of beer on the wall, {remainingBottles} bottles of beer.\n");

                if (remainingBottles - 1 > 1)
                {
                    beerSong.Append($"Take one down and pass it around, {remainingBottles - 1} bottles of beer on the wall.");
                }
                else if (remainingBottles - 1 == 1)
                {
                    beerSong.Append($"Take one down and pass it around, 1 bottle of beer on the wall.");
                }
                else if (remainingBottles - 1 == 0)
                {
                    beerSong.Append($"Take it down and pass it around, no more bottles of beer on the wall.");
                }
            }

            remainingBottles--;
        }

        return beerSong.ToString();
    }
}