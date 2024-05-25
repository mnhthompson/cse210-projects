
using System;


public class Order


{

    /// Contains a list of products and a customer. Can calculate the total cost of the order. Can return a string for the packing label. Can return a string for the shipping label.
    private List<Product> _products;
    private Customer _customer;

  



    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

/// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.


public double Shipping()
{
        double shippingCost = _customer.IsAmerican() ? 5 : 35;

        return shippingCost;
}

    public double CalculateTotalPrice()
    {
        double totalprice = 0;

        foreach (Product p in _products) 
        {
            double price = p.CalculatePrice();
            totalprice += price;
        }

        double shippingCost = Shipping();
        totalprice += shippingCost;
        return totalprice;
    }

/// A packing label should list the name and product id of each product in the order.

public string LabelerPacking()
{


        string _packLabel = "";
        foreach (Product p in _products) 
        {
            _packLabel += p.GetName() + " - " + p.GetProductID() + "\n";
        }
        


    return _packLabel;
}

/// A shipping label should list the name and address of the customer

public string LabelerShipping()
{

        string _shipLabel = "";
        _shipLabel += _customer.GetName() + "\n" + _customer.GenerateAddress();

    return _shipLabel;
}

/// The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.

public string TotalCost()
{

            string TrueTotal = "\nProducts:\n";
        double totalPrice = CalculateTotalPrice();
        foreach (Product p in _products) 
        {
            TrueTotal += p.GetName() + " (" + p.GetProductID() + ") - " + "$" + p.GetPrice() + " x " + p.GetQuantity() + " = " + p.CalculatePrice() + "\n";
        }
        
        TrueTotal += "Shipping: $" + Shipping()+ "\n" ;
        TrueTotal += "Total: $" + CalculateTotalPrice();
        
        

    
    return TrueTotal;

}

    public void Display()
    {

///Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results of these methods.
        string _pack = LabelerPacking();

        string _ship = LabelerShipping();

        string _cost = TotalCost();


        Console.WriteLine("Packing label");
        Console.WriteLine("");
        Console.WriteLine(_pack);
        Console.WriteLine("");
        Console.WriteLine("Shipping label");
        Console.WriteLine("");
        Console.WriteLine(_ship);
        Console.WriteLine("");
        Console.WriteLine("Cost");
        Console.WriteLine("");
        Console.WriteLine($"${_cost}");
        Console.WriteLine("");

    }



}
