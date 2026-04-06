public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string desc, string date, string time, Address addr, string email) 
        : base(title, desc, date, time, addr)
    {
        _rsvpEmail = email;
    }

    public override string GetFullDetails() => 
        $"{GetStandardDetails()}\nType: Reception\nRSVP to: {_rsvpEmail}";
}
