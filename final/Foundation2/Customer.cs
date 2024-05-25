



///The name is a string, but the Address is a class.



public class Customer

{

///The customer contains a name and an address.
private string _name;

private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }



///The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)

public bool IsAmerican()

{
     return _address.IsAmerican() ? true : false;
}

    public string GetName()
    {
        return _name;
    }

    public string GenerateAddress()
    {
        string generatedAddress = _address.MakeAdress();
        return generatedAddress;
    }


}