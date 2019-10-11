using System;
using System.Collections.Generic;

namespace classes {

    public class Employee {

        // Create a custom type for Employee. An employee has the following properties.
        // First name (string)
        // Last name (string)
        // Title (string)
        // Start date (DateTime)

        public string FirstName {get; set;}
        public string LastName  {get; set;}
        public string Title {get; set;}
        public DateTime StartingDate;

        //employee constructor with 4 arguments which are defined in betwee {}
        public Employee(string firstName, string lastName, string title, DateTime startingDate) {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            StartingDate = startingDate;

        }
    }
}