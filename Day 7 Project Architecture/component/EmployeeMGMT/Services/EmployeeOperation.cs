using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeMGMT.Models;
using EmployeeMGMT.Operations;
namespace EmployeeMGMT.Services
{
  public class EmployeeOperation : IEmployeeOperation  //Service Folder
{
    List<Employee> employees=new List<Employee>(); //Employees is an object of list type to hold the value
    //Now we will apply LINQ Query in emlpoyees list of Type 'Employees'.

    Employee IEmployeeOperation.Add(Employee employee)
    {
        employees.Add(employee); 
        return employee ;
    }

    Employee IEmployeeOperation.DeleteEmployeeId(int id)
    {
    Employee empToDelete = employees.FirstOrDefault(T => T.id == id); //first finding the employee with the given id using LINQ query.
    // Step 2: If found, remove from the list and return 1 (success)
    if (empToDelete != null)
    {
        employees.Remove(empToDelete);
        
        return empToDelete; // 1 record deleted
    }
    return null; // Return 0 if employee with that id does not exist.
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
 
    // Step 1: Use LINQ to locate the existing employee with matching id.
    Employee existingEmp = employees.FirstOrDefault(T => T.id == id);
    // Step 2: If found, update properties and return the updated object.
    if (existingEmp != null)
    {
        existingEmp.name = employee.name;
        existingEmp.age = employee.age;
        return existingEmp;
    }
    // Return null if employee with that id does not exist.
    return null;
}
        List<Employee> IEmployeeOperation.SearchByAge(int age)
        {
            List<Employee> res= employees.Where(t=>t.age>=age).ToList(); // query is not yet executed and at timeof foreach this will be executed this is known as deffered execution...
            //if the foreach loop is not used or created this execution will not happen 
  return res;
        }
}
}