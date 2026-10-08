// public class Products
// {
//     private int price;
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


//     Dictionary<int,Products> serverDict=new Dictionary<int,Products>();
//     public void ShowFromClass(string s)
//     {
//         foreach(int p in serverDict.Keys)
//         {   
//             if(serverDict[p].ProductClass.Equals(s)){
//             Console.WriteLine($"Product name is : {serverDict[p].ProductName}");
//             Console.WriteLine($"Product price is : {serverDict[p].ProductPrice}");}
//         }
//     }
//      public void ShowAllProduct()
//     {
//         foreach(int p in serverDict.Keys)
//         {   Console.WriteLine($"Product Id is : {p}");
//            Console.WriteLine($"Product class is : {serverDict[p].ProductClass}");
//             Console.WriteLine($"Product name is : {serverDict[p].ProductName}");
//             Console.WriteLine($"Product price is : {serverDict[p].ProductPrice}");
//         }
//     }
//     public void InsertAProduct(Products p,int key)
//     {
//        serverDict.Add(key,p);
//     }
//     public void RemoveAProduct(int key)
//     {
//         serverDict.Remove(key);
//     }
//     public Products search(int id)
//     {
//     return  serverDict[id];
//     }
//     public int InventorySize()
//     {
//         return serverDict.Count;
//     }
//     public void display(Products p,int pid)
//     {
//         Console.WriteLine($"Product name is {p.ProductName}");
//         Console.WriteLine($"Product class is {p.ProductClass}");
//         Console.WriteLine($"Product id is {pid}");
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
//                 int pids=Convert.ToInt32(Console.ReadLine());
//                 Console.WriteLine("Enter class of product : ");
//                 p.ProductClass=Console.ReadLine().ToLower();
//                 Console.WriteLine("Enter the price of product:");
//                 p.ProductPrice=Convert.ToInt32(Console.ReadLine());
//                 shivansh.InsertAProduct(p,pids);
//                  break;

//                  case 4:
//                   if(shivansh.InventorySize()==0){Console.WriteLine("Inventory alrady Empty");break;}
//                  Console.WriteLine("Please enter the Product id you want to remove : ");
//                 int id=Convert.ToInt32(Console.ReadLine());
//                if(!shivansh.serverDict.ContainsKey(id))Console.WriteLine("The product doesnot exists!!");
//                     else
//                     {
//                         shivansh.RemoveAProduct(id);
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
//                   if(Temp!=null)shivansh.display(Temp,pid);
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