//Generic class Implementation
class Customer<T> //Formal Variable in the Angular Bracket
{
    public void display(T a) //Function takes the values of a which is of Type 'T'
    {
        Console.WriteLine(a);
    }
}

//Generic function Declaration and demonstration
class Employee  //Standard class 
{
    public void EmployeeName<T>(T a) //<T> defines the nature of input may vary as per input as T can be of any type string,Int etc.
    {
        Console.WriteLine(a);
    }
}

//Generic interfaces Implentation and demonstration :

public interface Orders<T>{
    public void display(T a); //Method signature definition along with variable Type T 
}
class Carts<T> : Orders<T> //Class carts implements the Orders interface 
{
    void Orders<T>.display(T a){ //Method of Orders is overriden and takes input as T type variable a where T can be anything string , int etc...

      Console.WriteLine(a);
    }
}

//Generic Constraints implementation and Demonstration:

class OrderAmmount<T> where T: struct //Defines that the T can only be a value type 
{
    public void Display(T a)
    {
        Console.WriteLine($"The ammount of the giver order is {a}");
    }
}

class OrderClass<T> where T: class //Defines that the T can only be a refrence/class type 
{
    public void Display(T a)
    {
        Console.WriteLine($"The class of the giver order is {a}");
    }
}

class CustomerDetails : IDisposable //Explicitly calling the  interface to monitor and clean the Memory when possible
{
    private int id;
   private int OrderValue;
    private bool disposedValue;

    public string? CustomerName { get; set; }
    public int CustomerId
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
    public int CustomerOrderValue
    {
        get
        {
            return OrderValue;

        }
        set
        {
            OrderValue=value;
        }
    }

    protected virtual void Dispose(bool disposing) //this is where cleaning logic is implemented 
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
        }
    }

    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    // ~CustomerDetails()
    // {
    //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
class Organization
{
    public static void Main()
    {
        Customer<String> customer= new Customer<string>(); //Defining the type of T and initiating the instance
        customer.display("Customer name is Shivansh Tiwari"); //passing the value for the function as per defined type
        Customer<int> customer1=new Customer<int>();
        customer1.display(3401);   //Here same function takes the Int type input as type of T is changed from string to int

         Employee employee= new Employee(); //initiating the instance 
        employee.EmployeeName("Employee name is Ritik"); //passing the value for the function defining the type of T
       Employee employee1=new Employee();
        employee1.EmployeeName(223);   //Here same function takes the Int type input as type of T is changed from string to int

        Orders<int> orders=new Carts<int>(); //class instance of carts is created wrt orders interface for abstraction along with T defined as int here
        orders.display(13); //the overriden function is called  with the int type value passed to be printed

        OrderAmmount<int> orderammount=new OrderAmmount<int>(); //Here only int double etc. can be given as the generic constraint is set to be of value type only.
        orderammount.Display(1200000);

        OrderClass<string> orderclass=new OrderClass<string>(); //Here only the refrence type can be defined as generics constraint is set to be of class type for this class.
        orderclass.Display("Order is PrePaid"); 


        using(CustomerDetails consumer=new CustomerDetails())// using block is used through whichGarbage collector is given the pointer of this memory to monitor 
        {
            consumer.CustomerId=12;
            consumer.CustomerOrderValue=1200000;
            consumer.CustomerName="Shivansh Tiwari";
            Console.WriteLine(consumer.CustomerId);
             Console.WriteLine(consumer.CustomerName);
              Console.WriteLine(consumer.CustomerOrderValue);
        }  //as soon as tasks in the given brackets are ended the garbage collector deallocates it's instance memory and repurposes it.
 

    }
}