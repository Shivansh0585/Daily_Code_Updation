using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeMGMT.Models;
namespace EmployeeMGMT.Operations
{
     public interface IEmployeeOperation 
{
 public  Employee Add(Employee employee);
  public  List<Employee> GetEmployees(); 
  public  Employee GetEmployeesByID(int id); 

  public Employee UpdateEmployee(Employee employee, int id); 

    public Employee DeleteEmployeeId(int id); 

    public List<Employee> SearchByAge(int age);

}
}