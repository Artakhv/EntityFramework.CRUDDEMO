using System;

namespace EntityFramework.CRUDDEMO
{
    internal interface IEmployeeProvider
    {
        Employee Get(int id);
    }
}