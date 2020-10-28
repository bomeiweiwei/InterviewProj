using MVCVue.Repository.Partials;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MVCVue.DTO
{
    public class EmployeeDTO: Employees
    {
        public string Name { get; set; }
    }

    public class EmployeeViewModel
    {
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
