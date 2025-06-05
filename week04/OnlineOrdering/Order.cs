using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Customer GetCustomer()
    {
        return _customer;
    }
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public decimal GetTotalCost()
    {
        decimal productSum = 0;
        foreach (var product in _products)
        {
            productSum += product.GetTotalCost();
        }
        decimal shippingCost = _customer.LivesInUSA() ? 5 : 35;
        return productSum + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder("Packing Label:\n");
        foreach (Product product in _products)
        {
            label.AppendLine($"{product.GetName()} (ID): {product.GetProductId()} ");

        }
        return label.ToString().Trim();
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label: {_customer.GetName()} {_customer.GetAddress().GetFullAddress()}";
    }

}