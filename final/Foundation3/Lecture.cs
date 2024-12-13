public class Lecture : Event
{
    private string speaker;
    private int maxCapacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int maxCapacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.maxCapacity = maxCapacity;
    }

    public string GetSpeaker() => speaker;
    public int GetMaxCapacity() => maxCapacity;

    public override string GetEventType()
    {
        return "Lecture";
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nSpeaker: {speaker}\nMax Capacity: {maxCapacity}";
    }
}
