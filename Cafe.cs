using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Cafe
    {
        private List<Employee> employees = new List<Employee>();

        public Cafe(string nSM, string birthday, int telephone, string email, string position, string jobDescription)
        {
            Employee employee1 = new Employee(nSM, birthday, telephone, email, position, jobDescription);
            employees.Add(employee1);
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void ToString()
        {
            foreach (var employee in employees)
            {
                employee.getInfo();
            }
        }
    }
}
