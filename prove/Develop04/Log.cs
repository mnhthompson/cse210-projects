

public class Log


{
public string _name;
public string _duration;
public string _date;



  public void Display()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"({_name})");
        Console.WriteLine($"{ _duration} seconds");
    }

}