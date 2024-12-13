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

 
    private float CalculateHorsepower()
    {
 
        float speedInMps = Speed * 0.44704f;

  
        float force = 100;

 
        float powerInWatts = force * speedInMps;

        return powerInWatts / 745.7f;
    }

    public override string GetSummary()
    {
        float distance = Speed * (Duration / 60);
        float pace = 60 / Speed * Duration;
        float horsepower = CalculateHorsepower();

        return $"{Date:dd MMM yyyy} Cycling ({Duration} min) - Distance {distance:F1} miles, Speed {Speed:F1} mph, Pace: {pace:F1} min per mile, Horsepower: {horsepower:F2} HP";
    }
}
