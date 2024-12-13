using System;

public class Cycling : Activity
{
    private float _speed; 

    public Cycling(DateTime date, float duration, float speed)
        : base(date, duration)
    {
        _speed = speed;
    }


    public Cycling(float duration, float speed)
        : base(duration)
    {
        _speed = speed;
    }


    public float Speed => _speed;

    public override string GetSummary()
    {
        float distance = Speed * (Duration / 60); 
        float pace = 60 / Speed * Duration; 
        return $"{Date:dd MMM yyyy} Cycling ({Duration} min) - Distance {distance:F1} miles, Speed {Speed:F1} mph, Pace: {pace:F1} min per mile";
    }
}
