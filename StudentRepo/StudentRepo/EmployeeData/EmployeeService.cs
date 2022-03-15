using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRepo.EmployeeData
{
    public class EmployeeService
    {
        IEmployee _emp;
        public EmployeeService(IEmployee emp)
        {
            _emp = emp;
        }
        public List<Employee> GetEmployees()
        {
            return _emp.GetEmployees();
        }
        public Employee GetEmployee(int id)
        {
            return _emp.GetEmployee(id);
        }
        public void AddEmployee(Employee employee)
        {
            _emp.AddEmployee(employee);
        }
        public void UpdateEmployee(Employee employee)
        {
            _emp.UpdateEmployee(employee);
        }
        public void DeleteEmployee(Employee employee)
        {
            _emp.DeleteEmployee(employee);
        }
    }
}
