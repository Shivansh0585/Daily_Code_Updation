//Extension method(Most Important topic)

public  class Employee 
{
    public static void AddEmployee()
    {
        Console.WriteLine("Employee Added");
    }
}
public class Client
{
    public static void Main(string[] args)
    {
        Employee emp = new Employee();//I need to add the extra function in existing function using extension method..
       // emp.AddEmployee(); //Existing method 
        emp.GetEmployeeDetails(); //Extension method
        emp.GetEmployeeDetails();
    }
}

 // Rules of creating the extension method in existing class (Employee)
//1. Extension method should be defined in static class.
//2. Extension method should be static.

public static class EmployeeExtension
{
    public static void GetEmployeeDetails(this Employee x)
    {
        Console.WriteLine("GetEmployeeDetails function is added successfully using extension method");
    }
}