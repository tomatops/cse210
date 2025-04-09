using System;

class Program
{
    static void Main(string[] args)
    {
        // Setting values for the first order
        Address address1 = new Address("124 Bluebird", "Cornfield", "New York", "USA");
        Customer customer1 = new Customer("Sarah Johnson", address1);
        Product order1Product1 = new Product("Blue Ceramic Mug", "114", 26.38, 1);
        Product order1Product2 = new Product("Claw Hammer", "235", 10.95, 1);

        Order order1 = new Order();
        order1._products.Add(order1Product1);
        order1._products.Add(order1Product2);
        order1._customers.Add(customer1);

        // Setting values for the second order
        Address address2 = new Address("Hardinan", "Calauan", "Laguna", "Philippines");
        Customer customer2 = new Customer("Thea Tirazona", address2);
        Product order2Product1 = new Product("Food Storage Container", "187", 15.99, 3);
        Product order2Product2 = new Product("Insulated Water Bottle", "48", 20.49, 2);

        Order order2 = new Order();
        order2._products.Add(order2Product1);
        order2._products.Add(order2Product2);
        order2._customers.Add(customer2);

        // Displays shipping label, packing label, and total price of first order
        order1.GetShippingLabel();
        order1.GetPackingLabel();
        Console.WriteLine("--------------");
        Console.WriteLine($"Total Cost: ${order1.CalculateOrderCost()}");

        // Displays shipping label, packing label, and total price of second order
        order2.GetShippingLabel();
        order2.GetPackingLabel();
        Console.WriteLine("--------------");
        Console.WriteLine($"Total Cost: ${order2.CalculateOrderCost()}");
    }
}