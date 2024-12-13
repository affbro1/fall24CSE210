public class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public string GetRsvpEmail() => rsvpEmail;

    public override string GetEventType()
    {
        return "Reception";
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nRSVP via email: {rsvpEmail}";
    }
}
