public class Product
{
    private int _id;
    private string _name;
    private int _quantity;
    private int _price;

    public Product(int id, string name, int quantity, int price)
    {
        _id = id;
        _name = name;
        _quantity = quantity;
        _price = price;
    }

    public int TotalCost()
    {
        return _quantity * _price;
    }

    public string GetProductText()
    {
        return $"{_id} - {_name}";
    }
}