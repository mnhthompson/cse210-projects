using System;
using System.Runtime.Intrinsics.Wasm;



/// Make sure that all member variables are private and getters, setters, and constructors are created as needed.


class Program
{
    static void Main(string[] args)
    {
                // Order 1
        Address address1 = new Address("Cherry Rd 487", "San Antonia", "Texas", "USA");
        Customer _customer1 = new Customer("George Lopez", address1);
        List<Product> _productsList1 = new List<Product>();

        Product p1001 = new Product("Banana", "B1000", 5.80, 11);
        Product p1002 = new Product("Apple", "A200", .50, 5);
        Product p1003 = new Product("Cake", "C500", 10.99, 1);

        _productsList1.Add(p1001);
        _productsList1.Add(p1002);
        _productsList1.Add(p1003);

        Order order1 = new Order(_productsList1, _customer1);

        Console.WriteLine("Order Number: 1");
        order1.Display();
        Console.WriteLine();

        // Order 2
        Address address2 = new Address("Applewood Rd 487", "Hautvillers", "Champange", "France");
        Customer _customer2 = new Customer("George Georgerson", address1);
        List<Product> _productsList2 = new List<Product>();

        Product p2001 = new Product("BananaFriend", "BF1000", 50.80, 11);
        Product p2002 = new Product("ApplePie", "AP200", 15.50, 2);
        Product p2003 = new Product("HotCakes", "HC500", 20.99, 1);

        _productsList2.Add(p2001);
        _productsList2.Add(p2002);
        _productsList2.Add(p2003);

        Order order2 = new Order(_productsList2, _customer2);

        Console.WriteLine("Order Number: 2");
        order2.Display();
        Console.WriteLine();

        

        
    }


///Once you have created these classes, write a program that creates at least two orders with a 2-3 products each. 




}