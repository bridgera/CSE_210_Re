using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Costumer _costumer;
    private double _total;

    public Order(Costumer costumer)
    {
        _costumer = costumer;
    }

    public void GetTotal()
    {
        
        foreach (Product product in _products)
        {
            _total = _total + product.CalculateTotal();
        }

        double shipping = 0.00;

        if (_costumer.IsInUS() == true)
        {
            shipping = 5.00;
        }
        else
        {
            shipping = 35.00;
        }

        _total = _total + shipping;

        Console.WriteLine($"TOTAL: {_total}");
    }

    public void GetPackingLabel()
    {
        Console.WriteLine("PACKING LABEL");
        Console.WriteLine("_____________");
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetName() + "|" + product.GetID());
        }
    }

    public void GetShippingLabel()
    {
        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine("_____________");
        Console.WriteLine(_costumer.GetName());
        Console.WriteLine(_costumer.GetAddressString());
    }

    public void AddProduct(string name, string productID, double price, int quantity)
    {
        Product product = new Product(name, productID, price, quantity);
        _products.Add(product);
    }

    public void DisplayInfo()
    {
        Console.WriteLine("");
        GetShippingLabel();
        Console.WriteLine("");
        GetPackingLabel();
        Console.WriteLine("");
        GetTotal();
        Console.WriteLine("");
    }

}