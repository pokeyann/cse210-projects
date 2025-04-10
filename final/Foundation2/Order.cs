using System;


public class Order
{
  private List<Product> _products;
  private Customer _customer;

  public Order(Customer customer)
  {
    _customer = customer;
    _products = new List<Product>();
  }

  public void AddProduct(Product product)
  {
    _products.Add(product);
  }

  public double TotalCost()
  {
    double total = 0;
    foreach(Product product in _products)
    {
      total += product.GetTotalCost();
    }

    total += _customer.IsUSA() ? 5 : 35;
    return total;
  }

  public string GetPackingLabel()
  {
    string label = "Packing Label: ";
    foreach(Product product in _products)
    {
      label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
    }
    return label;
  }

  public string GetShippingLabel()
  {
    return $"Shipping Label: {_customer.GetName()} {_customer.GetAddress().GetFullAddress()}";
  }

}