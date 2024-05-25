using System;

public class OutdoorGathering : Event

{
    private string _weather;
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }

    public string GenerateWeatherStatement()
    {
        return "The forecast is " + _weather + ".";
    }

    public string ReturnEventType()
    {
        return "Outdoor Gathering";
    }
    public string CreateOutdoorGathering()
    {
        string detailed = "";
        string weatherStatement = GenerateWeatherStatement();
        
        detailed += CreateStandard() + "\n";
        detailed += "Weather: " + weatherStatement;
        return detailed;
    }
    public string CreateShortOutdoorGathering()
    {
        string shortOG = "";
        string eventType = ReturnEventType();

        shortOG += "Type: " + eventType + "\n";
        shortOG += CreateShort();
        return shortOG;
    }
}