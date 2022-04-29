using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static List<Employee> GetEmployees() 
        {
            List<Employee> employees = new List<Employee>();
            while(true) {
                // Get user input for employee and save to a new Employee instance
                Console.WriteLine("Please enter first name (leave empty to exit): ");
                string firstName = Console.ReadLine();
                if (firstName == "") {
                    break;
                }
                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter employee ID number: ");
                int employeeId = Int32.Parse(Console.ReadLine());
                Console.Write("Enter employee photo URL: ");
                string photoUrl = Console.ReadLine();

                // create new Employee instance
                Employee currentEmployee = new Employee(firstName, lastName, employeeId, photoUrl);
                // Add currentEmployee of Employee type
                employees.Add(currentEmployee);
            }
            // important
            return employees;
        }

        static void Main(string[] args)
        {
            // GetEmployees method call
            List<Employee> employees = GetEmployees();
            
            Console.WriteLine("Your employee list: ");
            // PrintEmployees method call, passing employees in as parameter.
            Util.PrintEmployees(employees);   
            Util.MakeCSV(employees);
            Util.MakeBadges(employees);
            
        }        
    }
}
