using System;

public class SpaceAge
{
    private readonly int Seconds;
    public SpaceAge(int seconds) => Seconds = seconds;

    public double CalculateSpaceAge(double orbitalYears) => OnEarth() / orbitalYears;

    public double OnEarth() => new TimeSpan(0, 0, 0, Seconds).TotalDays / 365.25d;

    public double OnMercury() => CalculateSpaceAge(0.2408467d);

    public double OnVenus() => CalculateSpaceAge(0.61519726d);

    public double OnMars() => CalculateSpaceAge(1.8808158d);

    public double OnJupiter() => CalculateSpaceAge(11.862615d);

    public double OnSaturn() => CalculateSpaceAge(29.447498d);

    public double OnUranus() => CalculateSpaceAge(84.016846d);

    public double OnNeptune() => CalculateSpaceAge(164.79132d);
}