using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        List<Product> products1 = new List<Product>();
        Product product1 = new Product("Toy", 357, 5.99, 3);
        Product product2 = new Product("Furniture", 554, 99.99, 2);
        
        products1.Add(product1);
        products1.Add(product2);

        Address address1 = new Address("525 S Center St", "Rexburg", "ID", "USA");

        Customer customer1 = new Customer("John Doe", address1);
        
        Order order1 = new Order(products1, customer1);
        double totalCost = order1.TotalCost();

        System.Console.WriteLine();
        order1.PackingLabel();
        order1.ShippingLabel();
        System.Console.WriteLine($"Total cost: ${totalCost}\n");

        // Order 2
        List<Product> products2 = new List<Product>();
        Product product1A = new Product("Plate", 237, .99, 10);
        Product product2A = new Product("Bracket", 579, 1.29, 3);

        products2.Add(product1A);
        products2.Add(product2A);
        
        Address address2 = new Address("220 E 1st S", "Rexburg", "ID", "Mexico");

        Customer customer2 = new Customer("Jane Doe", address2);
        
        Order order2 = new Order(products2, customer2);
        double totalCost2 = order2.TotalCost();

        System.Console.WriteLine();
        order2.PackingLabel();
        order2.ShippingLabel();
        totalCost2.ToString("#.##");
        System.Console.WriteLine($"Total cost: ${totalCost2}\n");
    }
}