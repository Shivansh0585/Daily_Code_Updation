//This will be containg the interface which will be implemented in the operations folder section.
using EMployeeMGST.Models;
namespace EMployeeMGST.Operations
{
    // All functions are blocking Applying the Task Parellism Library (TPL) to make it non-blocking.
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