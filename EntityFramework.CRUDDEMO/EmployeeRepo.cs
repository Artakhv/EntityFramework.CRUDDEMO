using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.CRUDDEMO
{
    internal class EmployeeRepo : IEmployeeRepo
    {
        private readonly EmplayeeContext employeeContext;

        public EmployeeRepo(EmplayeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }

        public Employee Create(string firstName, string lastName, string address, string homePhone, string cellPhone)
        {
            var response = employeeContext.Add(new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                HomePhone = homePhone,
                CellPhone = cellPhone
            });
            employeeContext.SaveChanges();
            return response.Entity;
        }

        public void Delete(Employee employee)
        {
            employeeContext.Remove(employee);
            employeeContext.SaveChanges();
        }

        public Employee Update(Employee employee)
        {
            var response = employeeContext.Update(employee);
            employeeContext.SaveChanges();
            return response.Entity;
        }
    }
}
