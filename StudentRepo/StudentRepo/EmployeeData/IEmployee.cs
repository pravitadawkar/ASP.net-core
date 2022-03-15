using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRepo.EmployeeData
{
    public interface IEmployee
    {
        public List<Employee> GetEmployees();
        public Employee GetEmployee(int id);
        public void AddEmployee(Employee employee);
        public void UpdateEmployee(Employee employee);
        public void DeleteEmployee(Employee employee);
    }
}
