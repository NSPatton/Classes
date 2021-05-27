using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            DateTime date = new DateTime(2021, 1, 26);
            Company thisCompany = new Company("BurgertownLLC", date);


            // Create three employees
            thisCompany.newEmployee(new Employee("Jimmy", "TwoFingers", "Fry Cook", new DateTime(2021, 4, 23)));
            thisCompany.newEmployee(new Employee("Jason", "Vargas", "Cashier", new DateTime(2021, 3, 12)));
            thisCompany.newEmployee(new Employee("Lana", "Goldberg", "Manager", new DateTime(2021, 6, 2)));
            thisCompany.newEmployeeList();




            // Assign the employees to the company




            // Iterate the company's employee list and generate the
            // simple report shown above




        }




        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */
    }
}
