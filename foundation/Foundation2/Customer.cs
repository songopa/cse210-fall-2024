public class Customer
{
    private string _name;
    private Address _address;

    public Customer (string name, string street, string city, string province, string country)
    {
        _name = name;
        _address = new Address(street, city, province, country);
    }

    public bool IsUsaAddress()
    {
        return _address.IsUsaAddress();
    }

    public string GetCustomerText()
    {
        return $"Name: {_name}\n{_address.GetAddressText()}";
    }
}