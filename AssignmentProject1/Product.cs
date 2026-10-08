// using System.Reflection.Metadata.Ecma335;

// public class Products
// {
//     private int price;
//     private int id;
//     private string name;
//     private string category;
    
//     public int ProductPrice
//     {
//         get
//         {
//             return price;
//         }
//         set
//         {
//             price=value;
//         }
//     }
//       public int ProductId
//     {
//         get
//         {
//             return id;
//         }
//         set
//         {
//             id=value;
//         }
//     }
//       public string ProductName
//     {
//         get
//         {
//             return name;
//         }
//         set
//         {
//             name=value;
//         }
//     }
//       public string ProductClass
//     {
//         get
//         {
//             return category;
//         }
//         set
//         {
//             category=value;
//         }
//     }
// }

// public class Customer
// {
//     List<Products> serverList=new List<Products>();
//     public void ShowFromClass(string s)
//     {
//         foreach(Products p in serverList)
//         {   
//             if(p.ProductClass.Equals(s)){
//             Console.WriteLine($"Product Id is : {p.ProductId}");
//             Console.WriteLine($"Product name is : {p.ProductName}");
//             Console.WriteLine($"Product price is : {p.ProductPrice}");}
//         }
//     }
//      public void ShowAllProduct()
//     {
//         foreach(Products p in serverList)
//         {   
//            Console.WriteLine($"Product class is : {p.ProductClass}");
//             Console.WriteLine($"Product Id is : {p.ProductId}");
//             Console.WriteLine($"Product name is : {p.ProductName}");
//             Console.WriteLine($"Product price is : {p.ProductPrice}");
//         }
//     }
//     public void InsertAProduct(Products p)
//     {
//         serverList.Add(p);
//     }
//     public void RemoveAProduct(Products p)
//     {
//         serverList.Remove(p);
//     }
//     public Products search(int id)
//     {
//     return  serverList.Find(a=>a.ProductId==id);
//     }
//     public int InventorySize()
//     {
//         return serverList.Count;
//     }
//     public void display(Products p)
//     {
//         Console.WriteLine($"Product name is {p.ProductName}");
//         Console.WriteLine($"Product class is {p.ProductClass}");
//         Console.WriteLine($"Product id is {p.ProductId}");
//         Console.WriteLine($"Product price is {p.ProductPrice}");
//     }
//     public static void Main()
//     {
//         Customer shivansh =new Customer();
//         Boolean looper=true;
//         while (looper)
//         {
//             Console.WriteLine("Enter your choice : ");
//             Console.WriteLine("Enter 1 for showing product from a specific class");
//             Console.WriteLine("Enter 2 for showing all of the products in inverntory");
//             Console.WriteLine("Enter 3 for insertig a new product in inventory");
//             Console.WriteLine("Enter 4 for removing a product from inventory");
//             Console.WriteLine("Enter 5 for checking total numbers of products in inventory");
//             Console.WriteLine("Enter 6 for searching a product in inventory by id");
//             Console.WriteLine("Enter 7 for exiting the program");
//             int response = Convert.ToInt32(Console.ReadLine());
//             switch (response)
//             {
//                 case 1:
//                  if(shivansh.InventorySize()==0){Console.WriteLine("Inventory alrady Empty");break;}
//                 Console.WriteLine("Enter the class of product you are searching :");
//                 string category=Console.ReadLine().ToLower();
//                 shivansh.ShowFromClass(category);
//                 break;

//                 case 2:
//                  if(shivansh.InventorySize()==0){Console.WriteLine("Inventory alrady Empty");break;}
//                 shivansh.ShowAllProduct();
//                 break;

//                 case 3:
//                 Products p=new Products();
//                 Console.WriteLine("Enter the product name : ");
//                 p.ProductName=Console.ReadLine().ToLower();
//                 Console.WriteLine("Enteer the product id :");
//                 p.ProductId=Convert.ToInt32(Console.ReadLine());
//                 Console.WriteLine("Enter class of product : ");
//                 p.ProductClass=Console.ReadLine().ToLower();
//                 Console.WriteLine("Enter the price of product:");
//                 p.ProductPrice=Convert.ToInt32(Console.ReadLine());
//                 shivansh.InsertAProduct(p);
//                  break;

//                  case 4:
//                   if(shivansh.InventorySize()==0){Console.WriteLine("Inventory alrady Empty");break;}
//                  Console.WriteLine("Please enter the Product id you want to remove : ");
//                 int id=Convert.ToInt32(Console.ReadLine());
//                Products t= shivansh.search(id);
//                if(t==null)Console.WriteLine("The product doesnot exists!!");
//                     else
//                     {
//                         shivansh.RemoveAProduct(t);
//                     }
//                  break;

//                  case 5:
//                  Console.WriteLine($"There are {shivansh.InventorySize()} products in inventory..");
//                  break;

//                  case 6:
//                  if(shivansh.InventorySize()==0){Console.WriteLine("Inventory alrady Empty");break;}
//                   Console.WriteLine("Enter the id of product you want to search : ");
//                   int pid=Convert.ToInt32(Console.ReadLine());
//                   Products Temp=shivansh.search(pid);
//                   if(Temp!=null)shivansh.display(Temp);
//                   else Console.WriteLine("The input id is not present for any product in inventory");
//                   break;

//                   case 7:
//                   looper=false;
//                   break;

//                   default:
//                   Console.WriteLine("Invalid input");
//                   break;
//             }
//         }
//     }
// }