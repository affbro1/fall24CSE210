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

    private float CalculateHorsepower()
    {
        
        float distance = _laps * 0.025f; 
        float speed = distance / (Duration / 60);

      
        float speedInMps = speed * 0.44704f;

       
        float force = 60;

      
        float powerInWatts = force * speedInMps;

      
        return powerInWatts / 745.7f;
    }

    public override string GetSummary()
    {
        float distance = _laps * 0.025f;
        float pace = Duration / _laps;
        float speed = distance / (Duration / 60);
        float horsepower = CalculateHorsepower();

        return $"{Date:dd MMM yyyy} Swimming ({Duration} min) - Distance {distance:F2} miles, Speed {speed:F1} mph, Pace: {pace:F1} min per lap, Horsepower: {horsepower:F2} HP";
    }
}
