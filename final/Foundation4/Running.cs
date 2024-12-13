using System;

public class Running : Activity
{
    private float _distance; 

    public Running(DateTime date, float duration, float distance)
        : base(date, duration)
    {
        _distance = distance;
    }


    public Running(float duration, float distance)
        : base(duration)
    {
        _distance = distance;
    }

    public float Distance => _distance;


    public override string GetSummary()
    {
        float pace = Duration / Distance; 
        float speed = Distance / (Duration / 60);
        return $"{Date:dd MMM yyyy} Running ({Duration} min) - Distance {Distance} miles, Speed {speed:F1} mph, Pace: {pace:F1} min per mile";
    }
}
