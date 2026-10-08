using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAssignmentProject.DataModel
{
  public class Product
{
    private int price;
    private int id;
    private string name;
    private string category;
    
    public int ProductPrice
    {
        get
        {
            return price;
        }
        set
        {
            price=value;
        }
    }
      public int ProductId
    {
        get
        {
            return id;
        }
        set
        {
            id=value;
        }
    }
      public string ProductName
    {
        get
        {
            return name;
        }
        set
        {
            name=value;
        }
    }
      public string ProductClass
    {
        get
        {
            return category;
        }
        set
        {
            category=value;
        }
    }
}
}