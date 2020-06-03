using System;

namespace EntityFramework.CRUDDEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new EmployeeProvider(new EmplayeeContext("Server=localhost;Database=Test;Trusted_Connection=True;"));
            var employee = provider.Get(1);
            Console.WriteLine($"Welcome {employee.FirstName}");
        }
    }
}
