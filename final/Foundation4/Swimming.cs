using System;

public class Swimming : Activity
{
    private int _laps;


    public Swimming(DateTime date, float duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }


    public Swimming(float duration, int laps)
        : base(duration)
    {
        _laps = laps;
    }


    public int Laps => _laps;


    public override string GetSummary()
    {
        float distance = _laps * 0.025f; 
        float pace = Duration / _laps; 
        float speed = distance / (Duration / 60); 
        return $"{Date:dd MMM yyyy} Swimming ({Duration} min) - Distance {distance:F2} miles, Speed {speed:F1} mph, Pace: {pace:F1} min per lap";
    }
}
