using MVCVue.Repository.Partials;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCVue.Repository.Interface
{
    public interface IUnitOfWorks
    {
        IGenericRepository<Employees> EmployeeRepository { get; }

        void SaveChanges();
    }
}
