using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass.Classes
{
    class Company
    {
        public string Name { get; }

        public DateTime CreatedOn { get; }

        public Company(string companyName, DateTime companyCreationDate)
        {
            Name = companyName;
            CreatedOn = companyCreationDate;
        }

        List<Employee> CurrentEmployees = new List<Employee>();

        public void showCurrentEmployees()
        {
            for (var i = 0; i < CurrentEmployees.Count; i++)
            {
                Console.Write(CurrentEmployees[i].EmployeeFirstName + ",");
            }
        }

        public void AddEmployee(string firstname, string lastname, string jobTitle)
        {
            var employeeToAdd = new Employee(firstname, lastname, jobTitle, DateTime.Now);
            CurrentEmployees.Add(employeeToAdd);
        }

        public void RemoveEmployee(int indexToRemove)
        {
            CurrentEmployees.Remove(CurrentEmployees[indexToRemove]);
        }
    }
}
