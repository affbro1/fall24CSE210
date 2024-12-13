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

    private float CalculateHorsepower()
    {

        float speed = Distance / (Duration / 60);


        float speedInMps = speed * 0.44704f;


        float force = 70;

        float powerInWatts = force * speedInMps;


        return powerInWatts / 745.7f;
    }

    public override string GetSummary()
    {
        float pace = Duration / Distance;
        float speed = Distance / (Duration / 60);
        float horsepower = CalculateHorsepower();

        return $"{Date:dd MMM yyyy} Running ({Duration} min) - Distance {Distance} miles, Speed {speed:F1} mph, Pace: {pace:F1} min per mile, Horsepower: {horsepower:F2} HP";
    }
}
