public class OutdoorGathering : Event
{
    private string _weatherStatement;

    public OutdoorGathering(string title, string desc, string date, string time, Address addr, string weather) 
        : base(title, desc, date, time, addr)
    {
        _weatherStatement = weather;
    }

    public override string GetFullDetails() => 
        $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {_weatherStatement}";
}
