using System;
using System.Collections.Generic;

namespace Classes
{
    public class Employee
    {

        public string FirstName { get; }
        public string LastName { get; }
        public string Title { get; }
        public DateTime startDate { get; }


        public Employee(string firstname, string lastname, String jobTitle, DateTime date)
        {
            FirstName = firstname;
            LastName = lastname;
            Title = jobTitle;
            startDate = date;
        }

    }
}