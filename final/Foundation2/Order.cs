using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product) => _products.Add(product);

    public double CalculateTotal()
    {
        double total = 0;
        foreach (var p in _products) total += p.GetTotalCost();

        double shipping = _customer.LivesInUSA() ? 5.00 : 35.00;
        return total + shipping;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder("PACKING LABEL:\n");
        foreach (var p in _products) sb.AppendLine(p.GetLabelData());
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL:\n{_customer.GetName()}\n{_customer.GetAddressString()}";
    }
}
