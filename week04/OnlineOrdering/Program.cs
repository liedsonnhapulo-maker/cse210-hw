using System;

class Program
{
    static void Main(string[] args)
    {
        // ORDER 1

        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        Product product1 = new Product("Laptop", "P100", 800, 1);
        Product product2 = new Product("Mouse", "P200", 20, 2);
        Product product3 = new Product("Keyboard", "P300", 50, 1);

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);


        // ORDER 2

        Address address2 = new Address(
            "45 Avenida Julius Nyerere",
            "Maputo",
            "Maputo",
            "Mozambique"
        );

        Customer customer2 = new Customer("Maria Silva", address2);

        Product product4 = new Product("Phone", "P400", 500, 1);
        Product product5 = new Product("Headphones", "P500", 60, 2);

        Order order2 = new Order(customer2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);


        // DISPLAY ORDER 1

        Console.WriteLine("==============================");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("==============================");

        Console.WriteLine("\nPACKING LABEL");
        Console.WriteLine("--------------------------------");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine("--------------------------------");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("\nTOTAL PRICE");
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Final Total: ${order1.CalculateTotalCost()}");


        // DISPLAY ORDER 2

        Console.WriteLine("\n==============================");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("==============================");

        Console.WriteLine("\nPACKING LABEL");
        Console.WriteLine("--------------------------------");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine("--------------------------------");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("\nTOTAL PRICE");
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Final Total: ${order2.CalculateTotalCost()}");
    }
}