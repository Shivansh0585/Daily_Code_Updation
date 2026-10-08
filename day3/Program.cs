using System.Collections;
class Employee
{    
    // public void practice()
    // {
    //     object var=21; //value type in refrence type (Boxing)
    //     int age=Convert.ToInt32(var);
    //     Console.WriteLine(age);
    // }
    public void practice()
    {
        ArrayList array =new ArrayList();
        array.Add("deepti");
        array.Add("21");
        foreach(object s in array)
        {
            Console.WriteLine(s);
        }
    }
    public static void Main()
    {
        Employee emp=new Employee();
        emp.practice();

    }
}