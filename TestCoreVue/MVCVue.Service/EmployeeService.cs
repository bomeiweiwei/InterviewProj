using AutoMapper;
using MVCVue.DTO;
using MVCVue.Repository.Interface;
using MVCVue.Repository.Partials;
using MVCVue.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCVue.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWorks _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeService(IUnitOfWorks unitOfWork)
        {
            _unitOfWork = unitOfWork;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employees, EmployeeDTO>();
            });
            IMapper mapper = config.CreateMapper();
            _mapper = mapper;
        }

        public List<EmployeeDTO> GetEmployee()
        {
            var employeeList = _unitOfWork.EmployeeRepository.Get().ToList();           
            return _mapper.Map<List<EmployeeDTO>>(employeeList);
        }

        public EmployeeDTO GetEmployeeId(int id)
        {
            var employeeEntity = _unitOfWork.EmployeeRepository.Get(item => item.EmployeeID == id).FirstOrDefault();
            return _mapper.Map<EmployeeDTO>(employeeEntity);
        }


        public void CreateEmployee(EmployeeDTO employee)
        {
            var employeeEntity = _mapper.Map<Employees>(employee);
            _unitOfWork.EmployeeRepository.Insert(employeeEntity);
            _unitOfWork.SaveChanges();
        }

        public void UpdateEmployee(EmployeeDTO employee)
        {
            var employeeEntity = _mapper.Map<Employees>(employee);
            _unitOfWork.EmployeeRepository.Update(employeeEntity);
            _unitOfWork.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var employeeEntity = _unitOfWork.EmployeeRepository.Get(item => item.EmployeeID == id).FirstOrDefault();
            _unitOfWork.EmployeeRepository.Delete(employeeEntity);
            _unitOfWork.SaveChanges();
        }
    }
}
