//Main function denotes the Frontend part which is for now the CLI but later can be replaced by the React and Angular for UI Purposes.
using EMployeeMGST.Models;
using EMployeeMGST.Operations;
using EMployeeMGST.Services;
using System.Text.Json;
namespace EMployeeMGST.UI
{
    public class main_Function
    {
        public static void Main()
        {
            IEmployeeOperation employeeOperation = new EmployeeOperation();
            //Adding Employee...................................................................................................................
            Employee emp1 = new Employee { id = 101, name = "Shivansh", age = 22 };
            Employee emp2 = new Employee { id = 102, name = "Umar", age = 21 };
            Employee emp3=new Employee {id=102,name = "vanshika", age =22 };
            employeeOperation.Add(emp1);
            employeeOperation.Add(emp2);
            employeeOperation.Add(emp3);

            //Getting All Employees..............................................................................................................
            List<Employee> employees = employeeOperation.GetEmployees();
            Console.WriteLine("All Employees:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.id}, Name: {emp.name}, Age: {emp.age}");
            }

            //Getting Employee by ID................................................................................................
            int searchId = 104;
            Employee searchedEmp = employeeOperation.GetEmployeesByID(searchId);
            if (searchedEmp != null)
            {
                Console.WriteLine($"\nEmployee with ID {searchId}: Name: {searchedEmp.name}, Age: {searchedEmp.age}");
            }
            else
            {
                Console.WriteLine($"\nEmployee with ID {searchId} not found.");
            }

            //Updating Employee.......................................................................................................
            Employee updatedEmp = new Employee { name = "Someone", age = 22 };
            Employee resultEmp = employeeOperation.UpdateEmployee(updatedEmp, searchId);
            if (resultEmp != null)
            {
                Console.WriteLine($"\nUpdated Employee with ID {searchId}: Name: {resultEmp.name}, Age: {resultEmp.age}");
            }
            else
            {
                Console.WriteLine($"\nEmployee with ID {searchId} not found for update.");
            }
    //Searching by age...............................................................................................................................
         
          List<Employee> employeesByAge = employeeOperation.SearchByAge(30);
          if(employeesByAge.Count()==0)Console.WriteLine("No record found");
           else{ Console.WriteLine($"All Employees with age 20 and above:");
           foreach (var emp in employeesByAge)
            {
                Console.WriteLine($"ID: {emp.id}, Name: {emp.name}, Age: {emp.age}");
            }
        }}
    }
}