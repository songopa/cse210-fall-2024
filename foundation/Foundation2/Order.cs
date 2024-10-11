public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProductToOrder(Product product)
    {
        _products.Add(product);
    }

    public int TotalProductCost()
    {
        int total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalCost(); 
        }

        return total;
    }

    public int ShippingCost()
    {
        if(_customer.IsUsaAddress())
        {
            return 5;
        } else
        {
            return 35;
        }
    }

    public int TotalOrderCost()
    {
        return TotalProductCost() + ShippingCost();
    }

    public void DisplayPackagingLabel()
    {
        foreach(Product product in _products)
        {
            Console.WriteLine(product.GetProductText());
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine($"{_customer.GetCustomerText()}");
    }

    public void DisplayOrderDetails()
    {
        Console.WriteLine($"\nORDER DETAILS");
        Console.WriteLine($"Packaging Label");
        Console.WriteLine($"ID  PRODUCT");
        DisplayPackagingLabel();
        Console.WriteLine($"Subtotal: ${TotalProductCost()} \nShipping: ${ShippingCost()} \nTotal: ${TotalOrderCost()}");
        Console.WriteLine($"\nShipping Label");
        DisplayShippingLabel();
    }
}