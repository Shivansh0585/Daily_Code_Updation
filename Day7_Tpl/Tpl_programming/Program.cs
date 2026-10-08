//Why TPL is the main agenda
using System.Threading;
class Product
{   //Below is an demonstration of what Synchronous programming would be looking like.
    // public static void Main()
    // {
    //     Product p=new Product();
    //     Console.WriteLine("Doing somework");
    //     p.fetchData(); //main thread working for this and is causing bottleneck and hence this method should better be called over a new thread...........
    //     Console.WriteLine("The long wait is over the further execution would happen here"); //main thread execution.......
    // }
    // public void fetchData() 
    // {
        
    //     Thread.Sleep(6000); //Delay time in miliseconds //Delay time in miliseconds , this causes the "Fire and Forget Situation......
    //     Console.WriteLine("Work is over");
    // }

    

      public static void Main()
    {
        Product p=new Product();
        Console.WriteLine("Doing somework");
        p.fetchData();
        Console.WriteLine("The long wait is over the further execution would happen here");
    }
    public void fetchData()
    {
        
        Thread.Sleep(15000); 
        Console.WriteLine("Work is over");
    }
}