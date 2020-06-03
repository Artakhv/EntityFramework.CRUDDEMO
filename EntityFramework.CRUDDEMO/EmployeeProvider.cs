using System.Linq;

namespace EntityFramework.CRUDDEMO
{
    internal class EmployeeProvider : IEmployeeProvider
    {
        private readonly EmplayeeContext employeeContext;

        public EmployeeProvider(EmplayeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }
        public Employee Get(int id)
        {
            return employeeContext.Employees.Where(e => e.Id == id).FirstOrDefault();
        }
    }
}
