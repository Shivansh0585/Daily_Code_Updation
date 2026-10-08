using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductAssignmentProject.DataModel;
namespace ProductAssignmentProject.Operations
{
     interface Customers
    {
        Product Add(Product p); //to Add a Product into the inventory 
        Product DeleteById(int id); // to delete a product from the inventory 
        List<Product> ShowByClass(string cls); //to show the product belonging to the same class
        List<Product> ShowByPrice(int price);  //Show the products according to the price provided
        List<Product> ShowByName(string name); //Show the product by name
        Product SearchById(int id); //Search and return the product of the given id
        Product UpdateById(int id,Product tem); //Update an existing Product with given info
    }
}