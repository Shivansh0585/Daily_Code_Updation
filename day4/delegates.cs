delegate void MyDelegate(); //can hold the reference of method for defined return type (void in this case) and defined parameter (none in this case).
class Employee
{
    public void Task()
    {
        Console.WriteLine("Task underway");
    }
    public int Expense()
    {
        return 1000;
    }
    public void Report()
    {
        Console.WriteLine("Apple");
    }
}
public class Office{

        public static void Main()
{
    Employee employee=new Employee();
     MyDelegate my= new MyDelegate(employee.Task); //This points to the reference to the function passed in constructor , in this case my acts as function pointer
     //pointing to the employee.task() function as passed in the construction.
     my.Invoke();
     my+=employee.Report; //This is MultiCast delegate this is used if we have to make delegate for two or more similar methods having similary signature
     //as shown in example Task and report

     my.Invoke(); //Invoke is a function to execute the delegate and delegate would execute the function (task function in this case).
}    //FIFO Principle , Explore more over the CoPilot .
    }