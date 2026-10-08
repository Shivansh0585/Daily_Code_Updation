using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductAssignmentProject.DataModel;
using ProductAssignmentProject.Operations;
using ProductAssignmentProject.Services;
namespace ProductAssignmentProject.UI
{
    public class UI
    {
        public static void Main()
        {
            Customers customers = new Consumers();

            customers.Add(new Product { ProductId = 1, ProductName = "Laptop", ProductPrice = 50000, ProductClass = "Electronics" });
            customers.Add(new Product { ProductId = 2, ProductName = "Mouse", ProductPrice = 500, ProductClass = "Electronics" });
            customers.Add(new Product { ProductId = 3, ProductName = "Chair", ProductPrice = 4000, ProductClass = "Furniture" });
            customers.Add(new Product { ProductId = 4, ProductName = "Laptop", ProductPrice = 60000, ProductClass = "Electronics" });

            Console.WriteLine("Search by ID (1):");
            Product p1 = customers.SearchById(1);
            if (p1 != null)
            {
                Console.WriteLine($"{p1.ProductId} | {p1.ProductName} | {p1.ProductPrice} | {p1.ProductClass}");
            }

            Console.WriteLine("\nShow by Name ('Laptop'):");
            List<Product> byName = customers.ShowByName("Laptop");
            foreach (var p in byName)
            {
                Console.WriteLine($"{p.ProductId} | {p.ProductName} | {p.ProductPrice} | {p.ProductClass}");
            }

            Console.WriteLine("\nShow by Price (<= 5000):");
            List<Product> byPrice = customers.ShowByPrice(5000);
            foreach (var p in byPrice)
            {
                Console.WriteLine($"{p.ProductId} | {p.ProductName} | {p.ProductPrice} | {p.ProductClass}");
            }

            Console.WriteLine("\nShow by Class ('Electronics'):");
            List<Product> byClass = customers.ShowByClass("Electronics");
            foreach (var p in byClass)
            {
                Console.WriteLine($"{p.ProductId} | {p.ProductName} | {p.ProductPrice} | {p.ProductClass}");
            }

            Console.WriteLine("\nUpdate by ID (2):");
            Product updatedProduct = new Product { ProductId = 2, ProductName = "Wireless Mouse", ProductPrice = 1200, ProductClass = "Electronics" };
            customers.UpdateById(2, updatedProduct);
            Product p2 = customers.SearchById(2);
            if (p2 != null)
            {
                Console.WriteLine($"{p2.ProductId} | {p2.ProductName} | {p2.ProductPrice} | {p2.ProductClass}");
            }

            Console.WriteLine("\nDelete by ID (3):");
            Product deleted = customers.DeleteById(3);
            if (deleted != null)
            {
                Console.WriteLine($"Deleted: {deleted.ProductId} | {deleted.ProductName}");
            }
        }
    }
}