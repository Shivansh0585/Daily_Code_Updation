using System;

namespace Enterprise
{
    class Employee
    {
        // Fields
        private string name;
        private int age;

        private int exp;

        // Property
        public int Salary { get; set; }

        // Constructor
        public Employee(string name, int age,int exp)
        {
            this.name = name;
            this.age = age;
            this.exp=exp;
        }

        // Method with return type
        public string GetDesDetails()
        {
            if (exp >= 10)
                return "Experienced Senior";
            else if (exp <10&&exp>=5)
                return "Senior";
            else if (exp <5&&exp>=2)
                return "Engineering team member";
        
            else
                return "Trainee/Fresher";
        }

        // Method
        public void Display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Experience: " + exp);
            Console.WriteLine("Rating: " + GetDesDetails());
        }

        // Method Overloading
        public void Display(string message)
        {
            Console.WriteLine(message);
        }

        // ref parameter
        public void IncreaseSalary(ref int salary)
        {
            salary = salary + 5000;
        }

        // out parameter
        public void GetEligibility(out string result)
        {
            if (exp >= 1)
                result = "Eligible";
            else
                result = "Under Review";
        }

        // in parameter
        public void ShowSalary(in int salary)
        {
            Console.WriteLine("Salary using in: " + salary);
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating object using constructor
            Employee employee = new Employee("Shivansh",21,2);

            // Property
            employee.Salary = 85000;

            // Normal method
            employee.Display();
            Console.WriteLine();

            // Overloaded method
            employee.Display("Employee information displayed successfully.");
            Console.WriteLine();

            // ref
            int salary = employee.Salary;
            employee.IncreaseSalary(ref salary);
            Console.WriteLine("Salary after ref: " + salary);
            Console.WriteLine();

            // out
            string result;
            employee.GetEligibility(out result);
            Console.WriteLine("Eligibility using out: " + result);
            Console.WriteLine();

            // in
            employee.ShowSalary(in salary);
        }
    }
}