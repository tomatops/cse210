public class Customer
{
    private string _name;
    private Address _address;

    // Sets values of member variables
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Returns whether the customer lives in USA or not
    public bool LivesInUSA()
    {
        return _address.IsUSA();
    }

    // Gets the customer name and address
    public string GetCustomer()
    {
        return $@"Name: {_name}
        Address: {_address.GetAddress()}";
    }
}