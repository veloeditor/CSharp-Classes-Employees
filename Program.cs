using System;
using System.Collections.Generic;

namespace classes {
    public class Program {
        static void Main(string[] args)
        {
            // In the Main method of your console application, create a new instance of Company, and three instances of Employee. Then assign the employees to the company.

            // Create an instance of a company. Name it whatever you like.
            Company Apple = new Company (new DateTime(1976, 4, 1), "Apple Computer Company");

             // Create three employees
            Employee SteveJobs = new Employee ("Steve", "Jobs", "CEO/Founder", new DateTime(1976, 4, 1));
            Employee SteveWoz = new Employee ("Steve", "Woz", "Co-Founder/Programmer", new DateTime(1976, 4, 1));
            Employee RonWayne = new Employee ("Ronald", "Wayne", "Co-Founder", new DateTime(1976, 4, 1));

            // Assign the employees to the company
            Apple.Employees.Add(SteveJobs);
            Apple.Employees.Add(SteveWoz);
            Apple.Employees.Add(RonWayne);

            //List the employees out (method is in Company.cs)
            Apple.ListEmployees();

        
        }

    }
}

