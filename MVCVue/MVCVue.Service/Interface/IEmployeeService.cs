using MVCVue.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCVue.Service.Interface
{
    public interface IEmployeeService
    {
        List<EmployeeDTO> GetEmployee();

        EmployeeDTO GetEmployeeId(int id);

        void CreateEmployee(EmployeeDTO employee);

        void UpdateEmployee(EmployeeDTO employee);

        void DeleteEmployee(int id);
    }
}
