using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeodev
{
    public class Employee
    {
        public int Age{ get; set; }
        public string Employees{ get; set; }
        public string FirstName { get; set; }   
        public int Id { get; set; } 
        public string LastName { get; set; }



        public Employee()
        {
            Console.WriteLine("Employee class initilazie..");
        }

        

        public Employee(int age, string employees, string firstName, int id, string lastName)
        {
            Age = age;
            Employees = employees;
            FirstName = firstName;
            Id = id;
            LastName = lastName;
        }

        public override string? ToString()
        {
            return $"{Age} {Employees} {FirstName} {Id} {LastName}";
        }





    }


}
