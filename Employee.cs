using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Employee 
    {
        private string FirstName;
        private string LastName;
        private int EmployeeId;
        private string PhotoUrl;

        public Employee(string firstName, string lastName, int employeeId, string photoUrl) {
            FirstName = firstName;
            LastName = lastName;
            EmployeeId = employeeId;
            PhotoUrl = photoUrl;
        }

        public string GetName() {
            return FirstName + " " + LastName;
        }

        public int GetId() {
            return EmployeeId;
        }

        public string GetPhotoUrl() {
            return PhotoUrl;
        }
    }
}