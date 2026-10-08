public class Employee{
    private int Eid;
    private string name;

    private long phno;

    public int EmployeeId
    {
        get{
            return Eid;
        }
        set
        {
            Eid=value;
        }
    }
     public string EmployeeName
    {
        get{
            return name;
        }
        set
        {
            name=value;
        }
    }
     public long EmployeePhno
    {
        get{
            return phno;
        }
        set
        {
            phno=value;
        }
    }
}

public class HR
{
    //Now we Need a container to store the value .. 
    List<Employee> employees =new List<Employee>(); //Act as Table in SQL server
    public void AddEmployee(Employee employee)
    {
        //Now performing add operation in employees object of ...  List type
        employees.Add(employee); // this one adds an record.

    }
     public void SearchEmployee(int id)
    {
       Employee res= employees .Find(a=>a.EmployeeId==id); //LINQ used for searching 
       
        
    }
     public void UpdateEmployee(Employee employee ,int id) //updating the record by id
    {
          
    }
     public void DeleteEmployee(int id) // Deleting the record based on id
    {
        
    }
     public void ShowEmployee()
    {
         foreach(Employee e in employees)
        {
            Console.WriteLine("Employee name :"+e.EmployeeName);
            Console.WriteLine("Employee id :"+e.EmployeeId);
            Console.WriteLine("Employee name :"+e.EmployeeName);
        }
        
    }
    public static void Main()
    {
     Employee emp=new Employee();
     emp.EmployeeId=101;
     emp.EmployeeName="Shivansh";
     emp.EmployeePhno=8934833751;

     HR hr=new HR();
     hr.AddEmployee(emp);
     hr.ShowEmployee();

    }
}