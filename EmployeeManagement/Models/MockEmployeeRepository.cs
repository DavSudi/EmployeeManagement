using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            { 
              new Employee(){Id = 1, Name = "Sudi", Department = Dept.IT, Email = "sudidav@thinktech.cd" } ,
              new Employee(){Id = 2, Name = "Sarah", Department = Dept.HR, Email = "sarahmay@thinktech.cd" } ,
              new Employee(){Id = 3, Name = "Helen", Department = Dept.Payroll, Email = "helenbeauty@thinktech.cd" }
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = _employeeList.FirstOrDefault(em => em.Id == id);
            if (employee != null)
            {
                _employeeList.Remove(employee);
            }

            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(em => em.Id == employeeChanges.Id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }

            return employee;
        }
    }
}
