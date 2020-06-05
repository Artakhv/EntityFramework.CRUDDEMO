using System;

namespace EntityFramework.CRUDDEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EmplayeeContext("Server=localhost;Database=Test;Trusted_Connection=True;");
            var provider = new EmployeeProvider(context);
            //var employee = provider.Get(1);
            //Console.WriteLine($"Welcome {employee.FirstName} {employee.LastName}");

            var repo = new EmployeeRepo(context);
            repo.Create("Name", "Lastname", "Address", "212425", "26655");
            var employee = provider.Get(2);
            Console.WriteLine($"Welcome {employee.FirstName} {employee.LastName}");

            //empoyee.FirstName = "FirstName";
            //repo.Update(empoyee);
            //repo.Delete(empoyee);
        }
    }
}
