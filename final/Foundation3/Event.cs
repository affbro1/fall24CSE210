public class Event
{
    private string title;
    private string description;
    private string date;
    private string time;
    private Address address;

    public Event(string title, string description, string date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GetTitle() => title;
    public string GetDescription() => description;
    public string GetDate() => date;
    public string GetTime() => time;
    public string GetAddress() => address.GetAddress();

    public string GetStandardDetails()
    {
        return $"Event: {title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {GetAddress()}";
    }
    public string GetShortDescription()
    {
        return $"{GetEventType()} Event: {title}\nDate: {date}";
    }

    public virtual string GetEventType()
    {
        return "General";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }
}
