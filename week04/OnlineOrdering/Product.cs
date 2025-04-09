public class Product
{
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;

    // Sets values of member variables
    public Product(string productName, string productId, double price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Calculates total cost of product
    public double CalculateProductCost()
    {
        return _price * _quantity;
    }

    // Gets the product name and id
    public string GetProduct()
    {
        return $"{_productName} ({_productId})";
    }
}