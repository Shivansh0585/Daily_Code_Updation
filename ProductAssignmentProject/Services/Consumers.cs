using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductAssignmentProject.DataModel;
using ProductAssignmentProject.Operations;
namespace ProductAssignmentProject.Services
{
    public class Consumers : Customers
    {
        List<Product> list =new List<Product>();
        Product Customers.Add(Product p)
        {
          Product res=list.Find(t=>t.ProductId==p.ProductId);
            if (res != null)
            {
                Console.WriteLine("The Id of the product is already in the database  please give another id for the product");
            }
            else list.Add(p);
            return p;
        }

        Product Customers.DeleteById(int id)
        {
            Product res=list.Find(t=>t.ProductId==id);
            if (res == null)
            {
                Console.WriteLine("The id is not valid please give a valid product id for delete operation ");
            }
            else list.Remove(res);
            return res;
        }

        Product Customers.SearchById(int id)
        {
           Product res=list.Find(t=>t.ProductId==id);
           return res;
        }

        List<Product> Customers.ShowByClass(string cls)
        {
         List<Product> res=list.Where(t=>t.ProductClass.Equals(cls)).ToList();
           return res;
        }

        List<Product> Customers.ShowByName(string name)
        {
           return list.Where(t=>t.ProductName.Equals(name)).ToList();
        }

        List<Product> Customers.ShowByPrice(int price)
        {
             return list.Where(t=>t.ProductPrice<=price).ToList();
        }

        Product Customers.UpdateById(int id, Product tem)
        {
            Product res=list.Find(t=>t.ProductId==id);
            if (res == null)
            {
                Console.WriteLine("No product exists for the given id please give a valid one creating a new record instead.....");
                return null;
            }
            res.ProductClass=tem.ProductClass; res.ProductId=tem.ProductId ; res.ProductName=tem.ProductName ;
            res.ProductPrice=tem.ProductPrice; 
            return res;
        }
    }
}