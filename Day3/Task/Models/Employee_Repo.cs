using WebApplication12.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication12.Models
{
    public class EmployeeRepo : IEmployeeRepo
    {
        EmployeeDbContext _context;

        public EmployeeRepo(EmployeeDbContext context)
        {
            _context = context;
        }

        public void AddEmployee(Employee obj)
        {
            _context.employees.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            Employee obj = _context.employees.Find(id);
            _context.employees.Remove(obj);
            _context.SaveChanges();
        }

        public List<Employee> GetAllEmployee()
        {
            List<Employee> emList = _context.employees.ToList();
            return emList;
        }

        public Employee GetEmployeeById(int id)
        {
            Employee obj = _context.employees.Find(id);
            return obj;
        }

        public void UpdateEmployee(Employee obj)
        {
            _context.employees.Update(obj);
            _context.SaveChanges();
        }
    }
}