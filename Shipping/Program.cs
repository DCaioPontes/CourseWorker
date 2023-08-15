﻿using System.ComponentModel;
using System.Globalization;
using System.Threading.Channels;
using Stock.Entities;

namespace Stock;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter client data:");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Birth date (DD/MM/YYYY): ");
        DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyy", CultureInfo.InvariantCulture);
        Client c1 = new Client(name, email, birthDate);

        Console.WriteLine("Enter order data: ");
        Console.Write("Status (PendingPayment/Processing/Shipped/Delivered): ");
        string status = Console.ReadLine();
        Console.Write("How many items to this order? ");
        int orderQnt = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= orderQnt; i++)
        {
            Console.WriteLine($"Enter #{i} item data: ");
            Console.Write("Product name: ");
            string nameProduct = Console.ReadLine();
            Console.Write("Product Price: ");
            double priceProduct = double.Parse(Console.ReadLine());
            Console.Write("Quantity: ");
            int qntProduct = int.Parse(Console.ReadLine());
            Product product = new Product(nameProduct, priceProduct);
            OrderItem item = new OrderItem(qntProduct, priceProduct, product);
        }
    }
}