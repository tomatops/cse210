public class Order
{
    public List<Product> _products = new List<Product>();
    public List<Customer> _customers = new List<Customer>();

    // Calculate total cost of order including the shipping cost
    public double CalculateOrderCost()
    {
        double orderCost = 0;
        bool isUSA = false;
        int shippingCost;

        foreach (Product product in _products)
        {
            orderCost += product.CalculateProductCost();
        }

        foreach (Customer customer in _customers)
        {
            isUSA = customer.LivesInUSA();
        }

        // If customer lives in USA, shipping cost is $5, if not shipping is $35
        if (isUSA == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        double totalCost = orderCost + shippingCost;
        return Math.Round(totalCost, 2);
    }

    // Displays name and product id of each product in the order
    public void GetPackingLabel()
    {
        Console.WriteLine("--------------");
        
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetProduct());
        }
    }

    // Displays name and address of the customer
    public void GetShippingLabel()
    {
        Console.WriteLine("==============");

        foreach (Customer customer in _customers)
        {
            Console.WriteLine(customer.GetCustomer());
        }
    }
}