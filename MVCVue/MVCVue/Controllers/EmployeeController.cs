using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCVue.DTO;
using MVCVue.Service.Interface;
using MVCVue.Web.Infrastructure;

namespace MVCVue.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(IEmployeeService employeeService, ILogger<EmployeeController> logger)
        {
            _employeeService = employeeService;
            _logger = logger;
        }

        [HttpGet]
        public ApiReponse<List<EmployeeViewModel>> List()
        {
            var employeeList = _employeeService.GetEmployee();
            var result = employeeList.Select(m => new EmployeeViewModel
            {
                Name = m.LastName + " " + m.FirstName,
                BirthDate = m.BirthDate.Value,
                HireDate = m.HireDate.Value,
                Address = m.Address,
                City = m.City,
                Country = m.Country,
            }).ToList();

            _logger.LogDebug(2, $"透過API取得Employee ViewModel 資料，筆數為{result.Count}");
            return new ApiReponse<List<EmployeeViewModel>>(result);
        }

        [HttpPost]
        [Route("create")]
        public BaseReponse Post([FromBody] EmployeeDTO employee)
        {
            _employeeService.CreateEmployee(employee);
            return new BaseReponse { Success = true };
        }

        [HttpPost]
        [Route("update")]
        public BaseReponse Update([FromBody] EmployeeDTO employee)
        {
            _employeeService.UpdateEmployee(employee);
            return new BaseReponse { Success = true };
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employeeService.DeleteEmployee(id);
        }

    }
}
