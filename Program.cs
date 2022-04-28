using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> employees = new List<string>();
            
            // get input from console and assign it to a value
            while  (true) {
                Console.WriteLine("Please enter an employee name: ");
                string input = Console.ReadLine();
                // Break if user enters an empty string
                if (input == "") {
                    break;
                }
                employees.Add(input);
            }

            Console.WriteLine("Your employee list: ");
            for(int i=0; i<employees.Count; i++) {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
