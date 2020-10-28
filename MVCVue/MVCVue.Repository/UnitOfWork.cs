using MVCVue.Repository.Data;
using MVCVue.Repository.Interface;
using MVCVue.Repository.Partials;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCVue.Repository
{
    public class UnitOfWork : IUnitOfWorks
    {
        private NorthwindContext _context;
        private GenericRepository<Employees> _employeeRepository;

        public UnitOfWork(NorthwindContext context)
        {
            _context = context;
        }

        public IGenericRepository<Employees> EmployeeRepository
        {
            get
            {
                if (this._employeeRepository == null)
                {
                    this._employeeRepository = new GenericRepository<Employees>(_context);
                }
                return _employeeRepository;
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
