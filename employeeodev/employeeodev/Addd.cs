using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeodev
{
    public class Addd
    {

        List<Employee> employees = new List<Employee>();

        public Addd()
        {
            employees = new List<Employee>(); 
        }

        public void CreateAdd(Employee employee)
        {
            employees.Add(employee);
        }

        public Employee ReadId(int idd)
        {
            return employees[idd];   
        }

        public Employee RemoveId(int idd)
        {
            var emp = ReadId(idd);
            employees.RemoveAt(idd);

            return emp;

        }
    }
}
