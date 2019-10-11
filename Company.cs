using System;
using System.Collections.Generic;

namespace classes {
    public class Company {

        // Create a custom type for Company. A company has the following properties.
        // Date founded (DateTime)
        // Company name (string)
        // Employees (List<Employee>)
        // The Company class should also have a ListEmployees() method which outputs the name of each employee to the console.

        public string _companyName {get;}
        public DateTime _dateCompanyFounded {get;}
        public List<Employee> Employees {get; set;}

        public Company(DateTime dateCompanyFounded, string companyName) {
            _dateCompanyFounded = dateCompanyFounded;
            _companyName = companyName;
            Employees = new List<Employee>();
        }

        public void ListEmployees() {
            Console.WriteLine();
            Console.WriteLine($"Employees of {_companyName}:");
            Console.WriteLine();
                foreach (Employee employee in Employees) {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.Title}, hired on {employee.StartingDate}");
                }
                    Console.WriteLine();
        }

    }
}