using System;

public class Reception : Event

{
    private string _email;
    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public string GetEmail()
    {
        return _email;
    }

    public string ReturnEventType()
    {
        return "Reception";
    }

    public string CreateReception()
    {
        string detailed = CreateStandard() + "\n";
        detailed += "RSVP: " + _email;
        return detailed;
    }
    public string CreateShortReception()
    {
        string shortReception = "";
        string eventType = ReturnEventType();
        shortReception += "Type: " + eventType + "\n";
        shortReception += CreateShort();
        return shortReception;
    }
}