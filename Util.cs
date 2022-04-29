using System;
using System.IO;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Util 
    {
        public static void PrintEmployees(List<Employee> employees) {
            for (int i=0; i < employees.Count; i++) {
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
            }
        }

        public static void MakeCSV(List<Employee> employees) {
            // check to see if folder exists
            if (!Directory.Exists("data")) {
                // if not, create it
                Directory.CreateDirectory("data");
            }

            using (StreamWriter file = new StreamWriter("data/employees.csv")) {
                // any code that needs the StreamWriter goes here
                file.WriteLine("ID,Name,PhotoUrl");
                // loop over employees and write data to csv file
                for (int i=0; i < employees.Count; i++) {
                    string template = "{0,-10}\t{1,-20}\t{2}";
                    file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
                }
            }
        }
    }
}