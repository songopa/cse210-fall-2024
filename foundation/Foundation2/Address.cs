public class Address
{
    private string _city;
    private string _province;
    private string _country;

    public Address(string city, string province, string country)
    {
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
        return $"City: {_city}, \nProvince: {_province}, \nCountry: {_country}";
    }
}