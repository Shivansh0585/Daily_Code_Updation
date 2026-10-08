using System.ComponentModel;
using System.Runtime.InteropServices;
class Employee //Models
{
    public int id { get; set; }
    public string name { get; set; }
    public int age { get; set; }

}

interface IEmployeeOperation //Operations folder
{
   int Add(Employee employee);//This Will make the Addition operation in generic (may return the number of records added).
    List<Employee> GetEmployees(); //This will be responsible for the Read and retrieval Operation and will return the resultant list.
    // void GetEmployees(); //This will be done by DTO Next time.
    Employee GetEmployeesByID(int id); //This will be used for searching and returning if the opject instance is found as per need. //Mainly to be done with DTO

   Employee UpdateEmployee(Employee employee, int id); //This will find and update the record and will return the updated data .

   int DeleteEmployeeId(int id); //This will fetch the record by id and will return the deleted id's credentials.

}

class EmployeeOperation : IEmployeeOperation  //Service Folder
{
    List<Employee> employees=new List<Employee>(); //Employees is an object of list type to hold the value
    //Now we will apply LINQ Query in emlpoyees list of Type 'Employees'.

    int IEmployeeOperation.Add(Employee employee)
    {
        employees.Add(employee); 
        return 1 ;
    }

    int IEmployeeOperation.DeleteEmployeeId(int id)
    {
       // Step 1: Use LINQ FirstOrDefault to search for the employee by id
    Employee empToDelete = employees.FirstOrDefault(T => T.id == id);
    // Step 2: If found, remove from the list and return 1 (success)
    if (empToDelete != null)
    {
        employees.Remove(empToDelete);
        return 1; // 1 record deleted
    }
    return 0;
    }

    List<Employee> IEmployeeOperation.GetEmployees()
    {
      return employees; //This will return the list of employees.
       
    }

    Employee IEmployeeOperation.GetEmployeesByID(int id)
    {
        //Now we Will be using LINQ Query to fetch the data 
        return employees.Find(T=>T.id==id);
      
    }

    Employee IEmployeeOperation.UpdateEmployee(Employee employee, int id)
    {
 
    // Step 1: Use LINQ to locate the existing employee with matching id
    Employee existingEmp = employees.FirstOrDefault(T => T.id == id);
    // Step 2: If found, update properties and return the updated object
    if (existingEmp != null)
    {
        existingEmp.name = employee.name;
        existingEmp.age = employee.age;
        return existingEmp;
    }
    // Return null if employee with that id does not exist
    return null;

}
}

class UI  //UI (Angular or react for now it's console)
{
    public static void Main()
    {
        IEmployeeOperation employeeOperation=new EmployeeOperation();
        Employee employee=new Employee();
       
        employee.age=22;employee.id=101;employee.name="Shivansh Tiwari";
        employeeOperation.Add(employee); //One record is added in employees list of type Employees(Object).
       
       List<Employee> fetchedData =employeeOperation.GetEmployees(); //This will return the fetched data. //To be used by DTO
       foreach(Employee emp2 in fetchedData)
        {
            Console.WriteLine($"Employee name is {emp2.name} , age is {emp2.age} , id is {emp2.id}");
        }
   
    Employee emp1=employeeOperation.GetEmployeesByID(101);
    if(emp1==null)Console.WriteLine("Record Not found");
    else Console.WriteLine($"Employee name is {emp1.name} , age is {emp1.age} , id is {emp1.id}");
 
 Employee temp1=new Employee();
 temp1.id=102;
 temp1.name="Shivaay";
 temp1.age=23;

    
    Employee holder=employeeOperation.UpdateEmployee(temp1,101);
       Console.WriteLine($"Employee name is {holder.name} , age is {holder.age} , id is {holder.id}");
       holder =new Employee();
       holder.name="Kartikey";
       holder.id=103;
       holder.age=25;
        
        employeeOperation.Add(holder);


      Console.WriteLine(employeeOperation.DeleteEmployeeId(102));

    
    }
}
//this program is not appropriate for Project as it has no Appropriate Logical instruction..