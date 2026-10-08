//1. Generic class Implementation in example
// class Employee<T>  //Creating Own Generic Class Where T(We can Give Any Name) is formal type Like we do in Integer and stuff.
// {
//     public void EmployeeAdress(T ctr)
//     {
//         Console.WriteLine(ctr);
//     }
// }
// class Office
// {
//    public static void Main()
//     {
//         // Employee<string> employee=new Employee<string>(); //A generic class object creation 
//         // employee.EmployeeAdress("Hello All"); //T acts as string here.
//         Employee<int> employee=new Employee<int>(); 
//         employee.EmployeeAdress(12345); //Here T Acts As integer type rather than String.


//     } 
// }

/// <summary>
/// Below program is for generic funtions...................................................................
/// </summary>
// class Employee
// {
//     public void Leave<T>(T data)
//     {
//         Console.WriteLine(data);
//     }
// }

// class Office
// {
//     public static void Main()
//     {
//         Employee employee=new Employee();
//         employee.Leave<String>("I want a leave"); //The function is having an String type input in here;

//         Employee employee1=new Employee();
//         employee.Leave<int>(12234); //The function is being used for integer type
//     }
// }

//.......................................................................................................................................................................
//3.Generic Interface Implementation Example...
//  interface Iwork<T>
// {
//     void Task(T a);
// }
// class Shivansh<T> : Iwork<T>
// {
//     void Iwork<T>.Task(T a)
//     {
//       Console.WriteLine(a);
//     }

// }
// class Office
// {
//     public static void Main()
//     {
//         Iwork<int> work=new Shivansh<int>(); 
//         work.Task(10);
//     } 
// }

//.........................................................................................................................................................................
//4.Generic Constraints

// class Employee<T> where T: struct  //This defines that the values in T can only be Value type int double and stuff
// // if we put where T: class the refrence type Like user defined types and strings can be used now (Either this or that unless where is missing)
// {
//     public void Task(T data)
//     {
//         Console.WriteLine(data);
//     }
// }
// class Office
// {
//     public static void Main()
//     {
//         Employee<int> emp=new Employee<int>();
//         emp.Task(2);
//     }
// }
