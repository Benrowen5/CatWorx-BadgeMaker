using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate new employees List
            List<Employee> employees = new List<Employee>();          
            
            Console.WriteLine("Do you want to fetch data from the API? Please enter 'yes' or 'no', or leave empty to exit.");
            string dataInput = Console.ReadLine();
            if (dataInput == "yes") {
                employees = PeopleFetcher.GetFromApi();   
            } else if (dataInput == "no") {
                employees = PeopleFetcher.GetEmployees();
            } else {
                Environment.Exit(0);
            }

            // PrintEmployees method call, passing employees in as parameter.
            Util.PrintEmployees(employees);   
            Util.MakeCSV(employees);
            Util.MakeBadges(employees);         
        }        
    }
}
