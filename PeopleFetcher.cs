using System;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker 
{
    class PeopleFetcher 
    {
        public static List<Employee> GetEmployees() 
        {
            List<Employee> employees = new List<Employee>();
            // Loop for taking User input for Employees
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
        public static List<Employee> GetFromApi() {
            List<Employee> employees = new List<Employee>();

            using (WebClient client = new WebClient()) {
                string response = client.DownloadString("https://randomuser.me/api/?results=10&nat=us&inc=name,id,picture");
                JObject json = JObject.Parse(response);
                // loop to parse data from JObject
                foreach (JToken person in json.SelectToken("results")) {
                    // parse JSON data
                    Employee emp = new Employee(
                       person.SelectToken("name.first").ToString(),
                       person.SelectToken("name.last").ToString(),
                       Int32.Parse(person.SelectToken("id.value").ToString().Replace("-", "")),
                       person.SelectToken("picture.large").ToString()
                    );
                    employees.Add(emp);
                }
            }
            return employees;
        }
    }
}