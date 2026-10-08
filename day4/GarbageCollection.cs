// //Program to implement and demonstrate the Grabage Collection
// public class Employee : IDisposable //This implements the explicit cleaning of the Assigned memory where possible
// {
//     int id; //Instance variable (Heap Memory)
//     private bool disposedValue;

//     public void Assign(int i)
//     {
//         id=i;
//         Console.WriteLine(id);
//     }


//     protected virtual void Dispose(bool disposing)
//     {
//         if (!disposedValue)
//         {
//             if (disposing)
//             {
//                 // TODO: dispose managed state (managed objects)
//             }

//             // TODO: free unmanaged resources (unmanaged objects) and override finalizer
//             // TODO: set large fields to null
//             disposedValue = true;
//         }
//     }

//     // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
//     // ~Employee()
//     // {
//     //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
//     //     Dispose(disposing: false);
//     // }

//     void IDisposable.Dispose()
//     {
//         // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
//         Dispose(disposing: true);
//         GC.SuppressFinalize(this);
//     }
// }
//     public class Office
// {
//     public static void Main()
//     {
//        using (Employee employee=new Employee()) //this is the using block using (creating an object inside the using block)
//         {
//               employee.Assign(10);
//         } //At this point the Garbage collector will be called automatically (GC) to call the dispose function to clean the memory 
        

//     }
// }