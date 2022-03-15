using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentRepo.DataBase;

namespace StudentRepo.EmployeeData
{
    public class EmployeeRepository:IEmployee
    {
        DatabaseContext _empcontext;
       public EmployeeRepository(DatabaseContext empcontext)
        {
            _empcontext = empcontext;
        }
        public List<Employee> GetEmployees()
        {
            return _empcontext.Employees.ToList();
        }
        public Employee GetEmployee(int id)
        {
            return _empcontext.Employees.FirstOrDefault(f => f.EmpId ==id);
        }
        public void AddEmployee(Employee employee)
        {
            _empcontext.Add(employee);
            _empcontext.SaveChanges();
        }
        public void UpdateEmployee(Employee employee)
        {
            _empcontext.Update(employee);
            _empcontext.SaveChanges();
        }
        public void DeleteEmployee(Employee employee)
        {
            _empcontext.Remove(employee);
            _empcontext.SaveChanges();
        }
    }
}
