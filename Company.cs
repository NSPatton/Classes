using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees

        public List<Employee> employee = new List<Employee>();

        public void listEmployees(string info)
        {
            for (int i = 0; i < employee.Count; i++)
            {
                Console.WriteLine(info);
            }
        }

        public void newEmployeeList()
        {
            foreach (Employee item in employee)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} has been here as {item.Title} since {item.startDate} ");
            }
        }




        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
        public Company(string name, DateTime Date)
        {
            Name = name;
            CreatedOn = CreatedOn;
        }

        public void newEmployee(Employee staff)
        {
            employee.Add(staff);
        }
    }
}
