using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static List<string> GetEmployees() 
        {
            List<string> employees = new List<string>();
            while(true) {
                Console.WriteLine("Please enter a name: (leave empty to exit): ");
                string input = Console.ReadLine();
                if (input == "") {
                    break;
                }

                employees.Add(input);
            }
            // important
            return employees;
        }

        static void PrintEmployees(List<string> employees) 
        {
            for (int i=0; i < employees.Count; i++) {
                Console.WriteLine(employees[i]);
            }
        }

        static void Main(string[] args)
        {
            // GetEmployees method call
            List<string> employees = GetEmployees();
            
            Console.WriteLine("Your employee list: ");
            // PrintEmployees method call, passing employees in as parameter.
            PrintEmployees(employees);   
            
        }        
    }
}
