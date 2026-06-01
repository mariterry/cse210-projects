using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA Customer)
        Address address1 = new Address(
            "123 Main Street",
            "Phoenix",
            "Arizona",
            "USA");

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P1001", 800, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 20, 2));
        order1.AddProduct(new Product("Keyboard", "P1003", 50, 1));

        // Order 2 (International Customer)
        Address address2 = new Address(
            "45 Avenida Eduardo Mondlane",
            "Maputo",
            "Maputo",
            "Mozambique");

        Customer customer2 = new Customer("Maria Santos", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Book", "P2001", 15, 2));
        order2.AddProduct(new Product("Notebook", "P2002", 8, 3));
        order2.AddProduct(new Product("Pen Set", "P2003", 6, 4));

        // Display Order 1
        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine("\nPACKING LABEL:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"\nTOTAL COST: ${order1.CalculateTotalCost():F2}");

        // Display Order 2
        Console.WriteLine("\n==============================");
        Console.WriteLine("===== ORDER 2 =====");

        Console.WriteLine("\nPACKING LABEL:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("SHIPPING LABEL:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"\nTOTAL COST: ${order2.CalculateTotalCost():F2}");
    }
}