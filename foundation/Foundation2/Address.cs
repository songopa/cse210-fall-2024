public class Address
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;

    public Address(string street, string city, string province, string country)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country;
    }

    public bool IsUsaAddress()
    {
        if (_country == "USA" || _country == "United States of America")
        {
            return true;
        } else
        {
            return false;
        }
    }

    public string GetAddressText()
    {
        return $"Street: {_street} \nCity: {_city}, Province: {_province}, Country: {_country}";
    }
}