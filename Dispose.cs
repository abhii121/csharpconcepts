using System;
using System.IO;
using System;
//a class called demonstratingclass is defined and it implements the IDidposable interface
public class demonstratingclass : IDisposable
{
    //the dispose() method is defined to to perform the release of the required resources
    public void Dispose()
    {
        Console.WriteLine("The dispose() function has been called and the resources have been released!");
    }
}
public class demofordispose
{
    public static void Main()
    { 
        var result = new demonstratingclass();
        result.Dispose();
    }
}